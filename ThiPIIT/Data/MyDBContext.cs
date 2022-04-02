using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ThiPIIT.Models;
namespace ThiPIIT.Data
{
    public class MyDBContext : DbContext
    {
        public MyDBContext():base("name=coinDBContext")
        {

        }
        public DbSet<Market> markets { get; set; }
        public DbSet<Coin> coins { get; set; }


    }
}