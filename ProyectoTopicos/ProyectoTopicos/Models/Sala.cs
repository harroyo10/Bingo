using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace ProyectoTopicos.Models
{
    public class Sala
    {
        [Display(Name = "ID")]
        public int SalaID { get; set; }

        [Display(Name = "Nombre de Sala")]
        [Required(ErrorMessage = "Nombre es requerido")]
        public string SalaNombre { get; set; }

        [Display(Name = "Características de Sala")]
        public string SalaCaracteristicas { get; set; }

        [Display(Name = "Cantidad de Asientos")]
        [Required(ErrorMessage = "Cantidad de asientos es requerido")]
        public int SalaCantidadAsientos { get; set; }

    }

    public class ProyectoDBContext : DbContext
    {
        public DbSet<Sala> Salas { get; set; }
        public DbSet<Precio> Precios { get; set; }
    }
}