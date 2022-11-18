namespace BeVelS.Graphics.Fonts.Interfaces
{
    using BeVelS.Graphics.Fonts.Structs.Characters;

    public interface IFontPacker
    {
        int Height { get; }

        void Add(
            ref CharacterData characterData);
    }
}