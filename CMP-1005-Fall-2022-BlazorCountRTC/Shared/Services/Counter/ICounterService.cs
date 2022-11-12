using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP_1005_Fall_2022_BlazorCountRTC.Shared.Services.Counter;

public interface ICounterService
{
    int Get();

    int Add(int numberToAdd);

    event EventHandler<int> CounterChanged;
}