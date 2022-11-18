namespace BeVelS.Graphics.Text.Classes
{
    using System;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;

    using BepuUtilities.Memory;

    using BeVelS.Graphics.Text.Interfaces;

    using BeVelS.Licensing.Classes;

    [BepuPhysicsLicensedCode(
        boilerplate: BepuPhysicsLicensedCodeAttribute.ApacheLicenseVersion20Boilerplate,
        copyrightOwner: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightOwner,
        copyrightYears: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightYears,
        source: "https://github.com/bepu/bepuphysics2/blob/master/DemoUtilities/TextBuilder.cs",
        BepuPhysicsLicensedCodeAttribute.FormattingChanges,
        "Replaced implicit conversions with GetCharacters method")]
    internal sealed class TextBuilder : ITextBuilder
    {
        private char[] characters;

        private int count;

        public ref char this[int index] { get { return ref characters[index]; } }

        public TextBuilder(
            int initialCapacity = 32)
        {
            characters = new char[initialCapacity];
        }

        public int Length
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return count; }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Debug.Assert(value >= 0);
                if (value > characters.Length)
                    Array.Resize(ref characters, value);
                count = value;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ITextBuilder Clear()
        {
            count = 0;

            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ITextBuilder Append(
            string text,
            int start,
            int count)
        {
            var newCount = this.count + count;
            if (newCount > characters.Length)
                Array.Resize(ref characters, SpanHelper.GetContainingPowerOf2(newCount));
            int end = start + count;
            for (int i = start; i < end; ++i)
            {
                characters[this.count++] = text[i];
            }
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ITextBuilder Append(
            string text)
        {
            return Append(
                text,
                0,
                text.Length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private char GetCharForDigit(
            int digit)
        {
            return (char)(digit + 48);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void Add(
            char character)
        {
            if (characters.Length == count)
                Array.Resize(ref characters, SpanHelper.GetContainingPowerOf2(count * 2));
            characters[count++] = character;

        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void AddDigit(
            ref double value,
            ref double multiplier)
        {
            var digit = (int)((value * multiplier) % 10);
            Add(GetCharForDigit(digit));
            value -= digit / multiplier;
            multiplier *= 10;
        }

        public ITextBuilder Append(
            double value,
            int decimalCount)
        {
            //This is a bit of a throwaway implementation and is far from the fastest or numerically best implementation,
            //but it is fairly simple and it doesn't matter very much.
            const double minimumDoubleMagnitude = 2.22507385850720138309023271733240406421921598046233e-308;
            if (double.IsNaN(value))
            {
                Append("NaN");
                return this;
            }
            if (double.IsPositiveInfinity(value))
            {
                Append("+INF");
                return this;
            }
            if (double.IsNegativeInfinity(value))
            {
                Append("-INF");
                return this;
            }


            bool negative = value < 0;
            if (negative)
                value = -value;
            if (value <= minimumDoubleMagnitude)
            {
                //Don't bother with signed zeroes.
                Add('0');
                return this;
            }
            if (negative)
            {
                Add('-');
            }
            value = Math.Round(value, decimalCount);
            var place = (int)Math.Floor(Math.Log10(value));
            var multiplier = Math.Pow(0.1, place);
            var epsilon = Math.Pow(0.1, decimalCount);
            if (value < epsilon)
            {
                Add('0');
            }
            else
            {
                for (int i = place; i >= 0; --i)
                {
                    AddDigit(ref value, ref multiplier);
                }
                if (value >= epsilon)
                {
                    Add('.');
                    for (int i = -1; i > place; --i)
                    {
                        Add('0');
                    }
                    do
                    {
                        AddDigit(ref value, ref multiplier);
                    } while (value > epsilon);
                }
            }
            return this;

        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ITextBuilder Append(
            long value)
        {
            return Append(
                value,
                0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ReadOnlySpan<char> GetCharacters()
        {
            return new ReadOnlySpan<char>(
                this.characters,
                0,
                this.count);
        }

        public override string ToString()
        {
            return new string(
                characters,
                0,
                count);
        }
    }
}