using System;
using System.Collections.Generic;
using System.Text;

namespace BtcTracker.Shared.Dto
{
    class AddressDto
    {
        public int ID { get; set; }
        public string Label { get; set; }
        public string CryptoAddress { get; set; }
        public double? Value { get; set; }
        public double? UsdValue { get; set; }
    }
}
