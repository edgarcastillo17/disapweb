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
        public int Id { get; set; }
        [Display(Name="Código")]
        public int ProductCode { get; set; }
        [Display(Name = "Código de Producto")]
        public string ProductName { get; set; }
        [Display(Name = "Nombre")]
        public string Description { get; set; }
        [Display(Name = "Descripción")]
        public int Quantity { get; set; }
        [Display(Name = "Cantidad")]
        public decimal Price { get; set; }
        [Display(Name = "Precio")]
        public int SupplierId { get; set; }
        [ForeignKey("SupplierId")]
        public Supplier Supplier { get; set; }
    }
}