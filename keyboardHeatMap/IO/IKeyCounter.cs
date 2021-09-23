using System.Collections.Generic;
using WindowsInput.Events;

namespace keyboardHeatMap.IO
{
    public interface IKeyCounter
    {
        void CountKeyDown(KeyCode key);
        Dictionary<KeyCode, int> Results();
        int TotalClicks();
    }
}