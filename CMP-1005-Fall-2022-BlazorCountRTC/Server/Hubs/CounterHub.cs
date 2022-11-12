using Microsoft.AspNetCore.SignalR;

namespace CMP_1005_Fall_2022_BlazorCountRTC.Server.Hubs
{
    public class CounterHub : Hub
    {
        int counter = 0;

        public async Task SendCount()
        {
            await Clients.All.SendAsync("NewCount", counter);
        }

        public async Task IncrementCount()
        {
            counter++;
            await SendCount();
        }
    }
}
