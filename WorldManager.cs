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
        private readonly static Dictionary<Int64, Player<IGameClient>> _players = new Dictionary<Int64, Player<IGameClient>>();
        public static List<Player<IGameClient>> Players => _players.Values.ToList();

        public static void Add(Player<IGameClient> player)
        {
            _players.Add(player.ID, player);
        }

        public static void Remove(Int64 playerID)
        {
            _players.Remove(playerID);
        }

        public static Player<IGameClient> GetPlayer(Int64 playerId)
        {
            return Players.FirstOrDefault(x => x.ID == playerId);
        }
    }
}
