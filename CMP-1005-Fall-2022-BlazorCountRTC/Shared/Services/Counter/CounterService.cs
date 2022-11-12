using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP_1005_Fall_2022_BlazorCountRTC.Shared.Services.Counter
{
    public class CounterService : ICounterService
    {
        private int _counter = 0;

        public event EventHandler<int>? CounterChanged;

        public int Add(int numberToAdd)
        {
            _counter += numberToAdd;
            CounterChanged?.Invoke(this, _counter);
            return _counter;
        }

        public int Get()
        {
            return _counter;
        }
    }
}
