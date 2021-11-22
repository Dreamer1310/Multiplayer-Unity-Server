using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityMovementServer.Connection
{
    public class PlayerDto
    {
        public Int64 ID { get; set; }
        public Double X { get; set; }
        public Double Z { get; set; }

        public PlayerDto(Player<IGameClient> player)
        {
            ID = player.ID;
            X = player.X;
            Z = player.Z;
        }
    }
}
