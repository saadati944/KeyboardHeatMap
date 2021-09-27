using keyboardHeatMap.Capture;
using keyboardHeatMap.IO;
using System;
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
    public interface IKHCore
    {
        void StartCapture();
        bool IsCapturing();
        void StopCapture();
        int KeyCount(KeyCode key);
        int TotalClicks();
        Dictionary<KeyCode, int> Results();
        void SaveToFile(string path, SaveFormat format, bool totalClicks, bool zeros = false);
    }
    public class Core : IKHCore
    {
        private IKeyboardCapture keyboardCapture;

        public Core()
        {
            keyboardCapture = new KeyboardCapture();
        }

        public void StartCapture()
        {
            keyboardCapture.Start();
        }
        public bool IsCapturing()
        {
            return keyboardCapture.IsCapturing;
        }
        public void StopCapture()
        {
            keyboardCapture.Stop();
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

        public void SaveToFile(string path, SaveFormat format, bool totalClicks, bool zeros = false)
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

            writer.WriteToDisk();
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

            writer.WriteToDisk();
        }
    }
}
