using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ControlInventario.Models
{
    public class Supplier
    {
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Display(Name = "Código de Proveedor")]
        public int SupplierCode { get; set; }

        [Display(Name = "Nombre de Proveedor")]
        public string SupplierName { get; set; }

        [Display(Name = "Correo Electrónico")]
        public string Email { get; set; }

        [Display(Name = "Teléfono")]
        public string Phone { get; set; }

        [Display(Name = "Dirección")]
        public string Address { get; set; }
    }
}