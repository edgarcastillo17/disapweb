using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ControlInventario.Models
{
    public class Supplier
    {
        public int Id { get; set; }
        [Display(Name = "Código")]
        public int SupplierCode { get; set; }
        [Display(Name = "Código de Proveedor")]
        public string SupplierName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
    }
}