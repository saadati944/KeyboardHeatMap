using System;
using WindowsInput.Events.Sources;
using keyboardHeatMap.IO;

namespace keyboardHeatMap.Capture
{
    public class KeyboardCapture : IKeyboardCapture
    {
        private IKeyboardEventSource keyboard;
        private IKeyCounter counter;
        public bool IsCapturing { get; private set; }

        public void Start()
        {
            IsCapturing = true;
            counter = new KeyCounter();
            keyboard = WindowsInput.Capture.Global.KeyboardAsync();
            keyboard.KeyEvent += Keyboard_KeyEvent;
        }
        
        private void Keyboard_KeyEvent(object sender, EventSourceEventArgs<KeyboardEvent> e)
        {
            var key = e.Data?.KeyDown?.Key;
            if(key != null)
                counter.CountKeyDown(key.Value);
        }

        public void Stop()
        {
            IsCapturing = false;
            keyboard.KeyEvent -= Keyboard_KeyEvent;
            keyboard.Dispose();
            keyboard = null;
        }

        public IKeyCounter Results()
        {
            return counter;
        }
    }
}