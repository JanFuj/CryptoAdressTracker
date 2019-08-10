using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BtcTracker.Data.Models
{
   public class Address
    {
        public int ID { get; set; }
        public string Label { get; set; }
        [Required(ErrorMessage = "Please enter a address")]
        public string CryptoAddress { get; set; }
        public double? Value { get; set; }
        public double? UsdValue { get; set; }
      
        public Currency Currency { get; set; }
      //  public ApplicationUser User { get; set; }
    }
}
