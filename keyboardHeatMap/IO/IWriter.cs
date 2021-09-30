namespace keyboardHeatMap.IO
{
    public interface IWriter
    {
        void Flush();
        void AddLine(string line);
        void Close();
    }
}