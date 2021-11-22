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
        public override Task OnConnectedAsync()
        {
            HandleUserConnet();
            return base.OnConnectedAsync();
        }

        public override Task OnDisconnectedAsync(Exception exception)
        {
            var id = Int64.Parse(Context.UserIdentifier);
            var player = WorldManager.GetPlayer(id);

            if (player != null)
            {
                WorldManager.Remove(id);
                Clients.All.PlayerDisconnected(id);
            }

            return base.OnDisconnectedAsync(exception);
        }

        private void HandleUserConnet()
        {
            Int64 id = Int64.Parse(Context.UserIdentifier);
            var player = new Player<IGameClient>()
            {
                ID = id,
                Client = Clients.Caller,
                X = 7,
                Z = 7
            };

            WorldManager.Add(player);
            Clients.Caller.PlayerData(new PlayerDto(player));
            Clients.Others.PlayerJoined(new PlayerDto(player));
            Clients.Caller.State(new StateDto
            {
                Players = WorldManager.Players.Select(x => new PlayerDto(x)).ToList()
            });
        }

        public void Disconnect()
        {
            var id = Int64.Parse(Context.UserIdentifier);
            WorldManager.Remove(id);
            Clients.All.PlayerDisconnected(id);
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
