using BtcTracker.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BtcTracker.Data.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options)
            : base(options)
        { }

        public DbSet<Currency> Currencies { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }
   
}


