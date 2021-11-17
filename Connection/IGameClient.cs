using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityMovementServer.Connection
{
    public interface IGameClient
    {
        public Task State(StateDto state);
        public Task Moved(Double x, Double y);
        public Task MovementError(String errorString);
        public Task PlayerJoined(Int64 playerID);
    }
}
