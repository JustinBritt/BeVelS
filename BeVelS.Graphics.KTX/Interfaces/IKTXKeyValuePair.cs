namespace BeVelS.Graphics.KTX.Interfaces
{
    public interface IKTXKeyValuePair
    {
        string Key { get; }

        byte[] Value { get; }
    }
}