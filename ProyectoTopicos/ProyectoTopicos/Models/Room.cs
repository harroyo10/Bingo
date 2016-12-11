using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ProyectoTopicos.Models
{
    public class Room
    {
        public int RoomID { get; set; }
        public string RoomName { get; set; }
        public string RoomCategory { get; set; }
        public string RoomDisponibility { get; set; }

    }

    public class RoomDBContext : DbContext
    {
        public DbSet<Room> Movies { get; set; }
    }
}