﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Cafeteria.Models
{
    public class Purchase
    {
        public int Id { get; set; }
        [Display(Name = "Código de Compra")]
        public int PurchaseId { get; set; }
        [Display(Name = "Nombre")]
        public string ClientName { get; set; }
        [Display(Name = "Cantidad")]
        public int Quantity { get; set; }
        [Display(Name = "Total")]
        public decimal Total { get; set; }
        [Display(Name = "Comentario")]
        public string Comment { get; set; }
        [Display(Name = "Estatus")]
        public string Status { get; set; }
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }
    }
}