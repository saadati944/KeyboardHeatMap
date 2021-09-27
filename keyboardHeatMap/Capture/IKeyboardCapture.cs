using System.Collections.Generic;
using WindowsInput.Events;
using keyboardHeatMap.IO;

namespace keyboardHeatMap.Capture
{
    public interface IKeyboardCapture
    {
        bool IsCapturing { get; }
        void Start();
        void Stop();
        IKeyCounter Counter();
    }
}