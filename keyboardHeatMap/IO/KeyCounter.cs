using System;
using System.Collections.Generic;
using WindowsInput.Events;

namespace keyboardHeatMap.IO
{
    public class KeyCounter : IKeyCounter
    {
        private Dictionary<KeyCode, int> result;
        private int totalClicks;

        public KeyCounter()
        {
            totalClicks = 0;
            result = new();
            foreach (KeyCode x in Enum.GetValues<KeyCode>())
                result.Add(x, 0);
        }
        
        public void CountKeyDown(KeyCode key)
        {
            totalClicks++;
            result[key]++;
        }

        public Dictionary<KeyCode, int> Results()
        {
            return result;
        }

        public int TotalClicks()
        {
            return totalClicks;
        }
    }
}