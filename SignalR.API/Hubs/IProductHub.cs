using SignalR.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalR.API.Hubs
{
    public interface IProductHub
    {
        Task ReceiveProduct(Product product);
    }
}
