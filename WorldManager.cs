using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityMovementServer.Connection;

namespace UnityMovementServer
{
    public class WorldManager
    {
        public static Dictionary<Int64, Player> Players;


        public static void NewPlayer(Int64 playerId)
        {
            var player = new Player { ID = playerId };
            Players.Add(playerId, player);
        }
    }
}
