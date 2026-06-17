using System;
using System.Collections.Generic;

using UnityEngine;

using ThirdPartyLib.Network;

using XXX.Core;





namespace XXX.Sample
{
    public class XXXSample
    {
        private int _counter;



        private readonly List<string> _messages = new List<string>();





        public int Counter
        {
            get => _counter;
            private set => _counter = value;
        }





        public void Refresh()
        {
            _counter++;

            _messages.Add($"Refresh {_counter}");

            Console.WriteLine($"Refresh {_counter}");
            Debug.Log($"Refresh {_counter}");
        }





        private class XXXSampleHelper
        {
            public string BuildLabel(string prefix, int value)
            {
                return $"{prefix}-{value}";
            }
        }
    }
}
