namespace BeVelS.Graphics.Text.Interfaces
{
    using System;

    using BeVelS.Graphics.Text.Classes;

    public interface ITextBuilder
    {
        int Length { get; set; }

        ITextBuilder Append(
            string text,
            int start,
            int count);

        ITextBuilder Append(
            string text);

        ITextBuilder Append(
            double value,
            int decimalCount);

        ITextBuilder Append(
            long value);

        ITextBuilder Clear();

        ReadOnlySpan<char> GetCharacters();
    }
}