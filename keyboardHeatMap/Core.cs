using keyboardHeatMap.Capture;
using keyboardHeatMap.IO;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsInput.Events;

namespace keyboardHeatMap
{
    public enum SaveFormat
    {
        TXT,
        CSV
    }
    public interface IKHCore : IDisposable
    {
        void StartCapture();
        bool IsCapturing();
        void StopCapture();
        int KeyCount(KeyCode key);
        int TotalClicks();
        Dictionary<KeyCode, int> Results();
        void Save(string path, SaveFormat format, bool totalClicks, bool zeros = false);
        void CreateHtml(string csvResultFile, string output);
    }
    public class Core : IKHCore
    {
        private IKeyboardCapture keyboardCapture;
        private IWriter tempWriter;
        private const string tempDirectory = "results";
        private readonly string tempPathPrefix = tempDirectory + Path.DirectorySeparatorChar + "result_";

        public Core()
        {
            keyboardCapture = new KeyboardCapture();
        }

        ~Core()
        {
            Destruct();
        }

        private void Destruct()
        {
            if (IsCapturing()) StopCapture();
        }

        public void StartCapture()
        {
            keyboardCapture.Start();
            CreateTempWriter();
        }
        public bool IsCapturing()
        {
            return keyboardCapture.IsCapturing;
        }
        public void StopCapture()
        {
            keyboardCapture.Stop();
            SaveCSV(tempWriter, keyboardCapture.Counter(), true, true);
            tempWriter.Close();
            tempWriter = null;
        }
        public int KeyCount(KeyCode key)
        {
            return keyboardCapture.Counter().KeyCount(key);
        }
        public int TotalClicks()
        {
            return keyboardCapture.Counter().TotalClicks();
        }
        public Dictionary<KeyCode, int> Results()
        {
            return keyboardCapture.Counter().Results();
        }

        public void Save(string path, SaveFormat format, bool totalClicks, bool zeros = false)
        {
            IWriter writer = new FileWriter(path);
            switch (format)
            {
                case SaveFormat.TXT:
                    SaveTXT(writer, keyboardCapture.Counter(), totalClicks, zeros);
                    break;
                case SaveFormat.CSV:
                    SaveCSV(writer, keyboardCapture.Counter(), totalClicks, zeros);
                    break;
            }
            writer.Close();
        }
        private void SaveCSV(IWriter writer, IKeyCounter counter, bool totalClicks, bool zeros)
        {
            writer.AddLine("Key,Count");

            if (totalClicks)
                writer.AddLine($"TotalClicks,{counter.TotalClicks()}");

            var results = counter.Results();

            List<KeyValuePair<KeyCode, int>> lst = results.ToList();
            lst.Sort((a, b) => b.Value.CompareTo(a.Value));

            foreach (var x in lst)
            {
                if (!zeros && x.Value == 0)
                    break;
                writer.AddLine($"{x.Key},{x.Value}");
            }

            writer.Flush();
        }
        private void SaveTXT(IWriter writer, IKeyCounter counter, bool totalClicks, bool zeros)
        {
            writer.AddLine("Key\t:\tCount");

            if (totalClicks)
                writer.AddLine($"TotalClicks\t:\t{counter.TotalClicks()}");

            var results = counter.Results();

            List<KeyValuePair<KeyCode, int>> lst = results.ToList();
            lst.Sort((a, b) => b.Value.CompareTo(a.Value));

            foreach (var x in lst)
            {
                if (!zeros && x.Value == 0)
                    break;
                writer.AddLine($"{x.Key}\t:\t{x.Value}");
            }

            writer.Flush();
        }

        private void CreateTempWriter()
        {
            if(tempWriter is not null) tempWriter.Close();

            if (!Directory.Exists(tempDirectory))
                Directory.CreateDirectory(tempDirectory);
            int num = 0;
            string path;
            do
            {
                path = $"{tempPathPrefix}{num}.csv";
                num++;
            } while (File.Exists(path));
            
            tempWriter = new FileWriter(path);
        }

        public void CreateHtml(string csvResultFile, string output)
        {
            int counter = -1;
            IWriter writer = new FileWriter(output);
            writer.AddLine(HtmlLayout.Prefix);
            foreach(string line in File.ReadAllLines(csvResultFile))
            {
                counter++;
                if(counter <= 1)
                    continue;
                string[] res = line.Split(',');
                if(counter == 2)
                {
                    writer.AddLine($"let maxCount = {res[1]};");
                    writer.AddLine("let KeysCount = {");
                }
                writer.AddLine($"'{res[0]}': {res[1]},");
            }
            writer.AddLine("}");
            writer.AddLine(HtmlLayout.Suffix);
            writer.Close();
        }
        

        public void Dispose()
        {
            Destruct();
        }
    }
}
