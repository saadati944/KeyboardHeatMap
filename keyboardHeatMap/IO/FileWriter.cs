using System.Collections.Generic;
using System.IO;
using System.Windows.Documents;

namespace keyboardHeatMap.IO
{
    public class FileWriter : IWriter
    {
        private StreamWriter writer;

        public FileWriter(string path)
        {
            writer = new StreamWriter(path);
        }

        public void Flush()
        {       
            writer.Flush();
            writer.Close();
        }

        public void AddLine(string line)
        {
            writer.WriteLine(line);
        }

        public void Close()
        {
            writer.Close();
        }
    }
}