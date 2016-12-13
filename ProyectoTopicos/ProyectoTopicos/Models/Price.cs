using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ProyectoTopicos.Models
{
    public class Price
    {

        public int PriceID { get; set; }
        public string PriceName { get; set; }
        public string PriceCategory { get; set; }
        public string PriceDisponibility { get; set; }

    }

    public class PriceDBContext : DbContext
    {
        public DbSet<Price> Salas { get; set; }
        
    }
}