using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BtcTracker.Data.Models
{
    public class Currency
    {

        public int ID { get; set; }
        public string Name { get; set; }

        public static readonly int BTC = 1;
        public static readonly int ETH = 2;
        public static readonly int LTC = 3;
        public static readonly int XMR = 4;

    }
}
