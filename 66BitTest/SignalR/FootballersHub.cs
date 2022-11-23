using Microsoft.AspNetCore.SignalR;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace _66BitTest.SignalR
{
    public class FootballersHub : Hub
    {
        public async Task Send(int id, string[] data)
        {
            await this.Clients.All.SendAsync("Send", id, data);
        }
    }
}
