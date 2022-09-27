using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidChart.API.Hubs
{
    public class CovidHub : Hub
    {
        public async Task GetCovidList()
        {
            await Clients.All.SendAsync("ReceiveCovidList", "Serviceden covid19 verilerini al");
        }
    }
}
