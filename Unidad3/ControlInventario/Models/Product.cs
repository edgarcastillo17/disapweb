using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ControlInventario.Models
{
    public class Product
    {
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Display(Name = "Código de Producto")]
        public int ProductCode { get; set; }

        [Display(Name = "Nombre de Producto")]
        public string ProductName { get; set; }

        [Display(Name = "Descripción")]
        public string Description { get; set; }

        [Display(Name = "Cantidad")]
        public int Quantity { get; set; }

        [Display(Name = "Precio")]
        public decimal Price { get; set; }
        
        public int SupplierId { get; set; }
        [ForeignKey("SupplierId")]
        public Supplier Supplier { get; set; }
    }
}