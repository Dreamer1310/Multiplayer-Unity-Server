using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityMovementServer
{
    public class Player<T>
    {
        public T Client { get; set; }
        public Int64 ID { get; set; }
        public Double X { get; set; }
        public Double Z { get; set; }
    }
}
