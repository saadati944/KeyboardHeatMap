namespace keyboardHeatMap.IO
{
    public interface IWriter
    {
        void WriteToDisk();
        void AddRow(string line);
    }
}