namespace BeVelS.Graphics.Fonts.Classes
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;

    using BeVelS.Graphics.Fonts.Interfaces;
    using BeVelS.Graphics.Fonts.Structs.Characters;

    using BeVelS.Licensing.Classes;

    [BepuPhysicsLicensedCode(
        boilerplate: BepuPhysicsLicensedCodeAttribute.ApacheLicenseVersion20Boilerplate,
        copyrightOwner: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightOwner,
        copyrightYears: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightYears,
        source: "https://github.com/bepu/bepuphysics2/blob/master/DemoContentBuilder/FontPacker.cs",
        BepuPhysicsLicensedCodeAttribute.FormattingChanges)]
    internal sealed class FontPacker : IFontPacker
    {
        int atlasWidth;
        int alignmentMask;
        int padding;
        int paddingx2;

        int start;
        int rowIndex;

        struct Interval
        {
            public int Start;
            public int End; //Technically redundant, but it simplifies the implementation a little. Performance doesn't matter.
            public int Height;

            public override string ToString()
            {
                return $"[{Start}, {End}): {Height}";
            }
        }

        List<Interval> intervals;

        public FontPacker(
            int width,
            int mipLevels,
            int padding,
            int characterCount)
        {
            this.atlasWidth = width;

            this.alignmentMask = (1 << mipLevels) - 1;

            this.padding = padding;

            this.paddingx2 = padding * 2;

            this.intervals = new List<Interval>(
                characterCount);

            this.intervals.Add(
                new Interval 
                { 
                    Start = 0, 
                    End = atlasWidth, 
                    Height = 0 
                });
        }

        public int Height { get; private set; }

        int AddAndGetBaseHeight(
            int queryStart,
            int queryEnd,
            int newGlyphHeight)
        {
            Debug.Assert(queryStart >= 0 && queryStart < this.atlasWidth && queryEnd > 0 && queryEnd <= this.atlasWidth);

            // Performance doesn't matter here. Just scan through the interval set until the first interval that is fully overlapped by the query interval.
            int firstOverlappedIndex = this.intervals.Count;

            int baseHeight = 0;

            for (int i = 0; i < this.intervals.Count; ++i)
            {
                Interval interval = this.intervals[i];

                if (interval.End > queryStart)
                {
                    firstOverlappedIndex = i;

                    baseHeight = interval.Height;

                    break;
                }
            }

            // Now scan until the first interval after that that doesn't overlap.
            int lastOverlappedIndex = firstOverlappedIndex;

            for (int i = firstOverlappedIndex + 1; i < this.intervals.Count; ++i)
            {
                Interval interval = this.intervals[i];

                if (interval.Start < queryEnd)
                {
                    if (interval.Height > baseHeight)
                        baseHeight = interval.Height;
                    lastOverlappedIndex = i;
                }
                else
                    break;
            }

            // Align and round up base height.
            baseHeight = (baseHeight + this.alignmentMask) & (~this.alignmentMask);

            Interval firstInterval = intervals[firstOverlappedIndex];

            Interval queryInterval;

            queryInterval.Start = queryStart;

            queryInterval.End = queryEnd;

            queryInterval.Height = baseHeight + newGlyphHeight;

            if (queryInterval.Height > this.Height)
                this.Height = queryInterval.Height;

            Debug.Assert(queryInterval.End > queryInterval.Start);

            if (firstOverlappedIndex == lastOverlappedIndex && firstInterval.Start <= queryStart && firstInterval.End >= queryEnd)
            {
                if (firstInterval.Start == queryStart && firstInterval.End == queryEnd)
                {
                    // Perfect replacement.
                    this.intervals[firstOverlappedIndex] = queryInterval;
                }
                else if (firstInterval.Start == queryStart)
                {
                    // The new interval should be inserted before the firstInterval. Modify the first interval.
                    firstInterval.Start = queryEnd;

                    Debug.Assert(firstInterval.End > firstInterval.Start);
                    
                    this.intervals[firstOverlappedIndex] = firstInterval;
                    
                    this.intervals.Insert(
                        firstOverlappedIndex,
                        queryInterval);
                }
                else if (firstInterval.End == queryEnd)
                {
                    //The new interval should be inserted after the firstInterval. Modify the first interval.
                    firstInterval.End = queryStart;

                    Debug.Assert(firstInterval.End > firstInterval.Start);
                    
                    this.intervals[firstOverlappedIndex] = firstInterval;
                    
                    this.intervals.Insert(
                        firstOverlappedIndex + 1,
                        queryInterval);
                }
                else
                {
                    // The query interval is inside of an interval, with space available on either side.
                    // Add two more intervals- the query interval, and the interval on the other side.
                    // We treat the existing interval as the left side.
                    Interval otherSideInterval = firstInterval;
                    
                    otherSideInterval.Start = queryEnd;
                    
                    firstInterval.End = queryStart;
                    
                    Debug.Assert(firstInterval.End > firstInterval.Start);
                    
                    this.intervals[firstOverlappedIndex] = firstInterval;

                    this.intervals.Insert(
                        firstOverlappedIndex + 1,
                        queryInterval);
                    
                    Debug.Assert(otherSideInterval.End > otherSideInterval.Start);
                    
                    this.intervals.Insert(
                        firstOverlappedIndex + 2,
                        otherSideInterval);
                }
            }
            else
            {
                // The query covers more than one interval.
                int removalStartIndex;

                if (firstInterval.Start == queryStart)
                {
                    // The first overlapped index is contained by the query interval. It should be removed.
                    removalStartIndex = firstOverlappedIndex;
                }
                else
                {
                    // The first overlapped index isn't contained; modify its end to match the query start.
                    removalStartIndex = firstOverlappedIndex + 1;
                
                    firstInterval.End = queryStart;
                    
                    Debug.Assert(firstInterval.End > firstInterval.Start);
                    
                    this.intervals[firstOverlappedIndex] = firstInterval;
                }

                Interval lastInterval = this.intervals[lastOverlappedIndex];

                int removalEndIndex;

                if (lastInterval.End == queryEnd)
                {
                    // The last overlapped interval is contained by the query interval. It should be removed.
                    removalEndIndex = lastOverlappedIndex;
                }
                else
                {
                    //The last overlapped interval isn't contained; modify its start to match the query end.
                    removalEndIndex = lastOverlappedIndex - 1;

                    lastInterval.Start = queryEnd;
                    
                    Debug.Assert(lastInterval.End > lastInterval.Start);
                    
                    this.intervals[lastOverlappedIndex] = lastInterval;
                }
                // Note that the end is an inclusive bound. The total number of contained intervals is removalEndIndex - removalStartIndex + 1,
                // but reusing one of them avoids an unnecessary insert.
                int removedCount = removalEndIndex - removalStartIndex;

                if (removedCount >= 0)
                {
                    this.intervals.RemoveRange(
                        removalStartIndex,
                        removalEndIndex - removalStartIndex);
                
                    this.intervals[removalStartIndex] = queryInterval;
                }
                else
                {
                    this.intervals.Insert(
                        removalStartIndex,
                        queryInterval);
                }
            }

            return baseHeight;
        }

        private void FillCharacterMinimum(
            ref CharacterData characterData,
            int end)
        {
            characterData.SourceMinimum.X = padding + start;

            characterData.SourceMinimum.Y = padding + this.AddAndGetBaseHeight(start, end, (int)characterData.SourceSpan.Y + this.paddingx2);
        }

        public void Add(
            ref CharacterData characterData)
        {
            int allocationWidth = (int)(this.paddingx2 + characterData.SourceSpan.X);

            if (allocationWidth > this.atlasWidth)
            {
                throw new ArgumentException(
                    "A single character that's wider than the entire atlas isn't gonna work. Is the FontPacker incorrectly initialized? Is the rasterized font size ridiculously huge?");
            }
            if ((this.rowIndex & 1) == 0)
            {
                // Place glyphs from left to right.
                this.start = (this.start + this.alignmentMask) & (~this.alignmentMask);

                int end = this.start + allocationWidth;

                if (end <= this.atlasWidth)
                {
                    this.FillCharacterMinimum(
                        ref characterData,
                        end);
                    
                    this.start = end;
                }
                else
                {
                    // This glyph doesn't fit; need to move to the next row.
                    ++this.rowIndex;
                    
                    this.start = this.atlasWidth;
                    
                    this.Add(
                        ref characterData);
                }
            }
            else
            {
                // Place glyphs from right to left.
                this.start -= allocationWidth;

                if (this.start >= 0)
                {
                    // Delayed alignment; alignment will never make this negative.
                    this.start = this.start & (~this.alignmentMask);

                    int end = this.start + allocationWidth;
                    
                    this.FillCharacterMinimum(
                        ref characterData,
                        end);
                }
                else
                {
                    // This glyph doesn't fit; need to move to the next row.
                    ++this.rowIndex;

                    this.start = 0;
                    
                    this.Add(
                        ref characterData);
                }
            }
        }
    }
}