using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace ProyectoTopicos.Models
{
    public class Precio
    {
        [Display(Name = "ID")]
        public int PrecioID { get; set; }

        [Display(Name = "Categoría")]
        [Required(ErrorMessage = "Categoría de precio es requerido")]
        public string PrecioCategoria { get; set; }

        [Display(Name = "Valor")]
        [Required(ErrorMessage = "El valor del precio es requerido")]
        public double PrecioValor { get; set; }

        [Display(Name = "Artefactos Adicionales")]
        public string PrecioArtefactos { get; set; }
    }

}