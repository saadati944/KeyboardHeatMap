using System.Collections.Generic;
using System.IO;
using System.Windows.Documents;

namespace keyboardHeatMap.IO
{
    public class FileWriter : IWriter
    {
        private string path;
        private List<string> lines;

        public FileWriter(string path)
        {
            this.path = path;
        }

        public void WriteToDisk()
        {
            var writer = new StreamWriter(path);
            foreach (var line in lines)
                writer.WriteLine(line);
        }

        public void AddLine(string line)
        {
            lines.Add(line);
        }
    }
}