namespace keyboardHeatMap.IO
{
    public interface IWriter
    {
        void WriteToDisk();
        void AddLine(string line);
    }
}