using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityMovementServer.Connection
{
    public class GameHub : Hub<IGameClient>
    {
        private static Int64 count = 0;
        public override Task OnConnectedAsync()
        {
            count++;
            Clients.All.PlayerJoined(count);
            return base.OnConnectedAsync();
        }

        public void MoveForward()
        {
        }

        public void MoveLeft()
        {
        }

        public void MoveRight()
        {
        }

        public void MoveBackward() 
        { 
        }
    }
}
