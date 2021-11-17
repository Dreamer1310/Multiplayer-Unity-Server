using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityMovementServer.Connection
{
    public class StateDto
    {
        public Int64 MyID { get; set; }
        public List<Player> Players { get; set; }
    }
}
