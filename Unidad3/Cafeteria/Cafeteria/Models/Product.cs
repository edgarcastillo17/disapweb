using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Cafeteria.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Display(Name = "Código de Producto")]
        public int ProductId { get; set; }
        [Display(Name = "Nombre")]
        public string ProductName { get; set; }
        [Display(Name = "Tipo")]
        public string Type { get; set; }
        [Display(Name = "Descripción")]
        public string Description { get; set; }
        [Display(Name = "Precio")]
        public int Price { get; set; }
        [Display(Name = "Imagen")]
        public byte[] Image { get; set; }
    }
}