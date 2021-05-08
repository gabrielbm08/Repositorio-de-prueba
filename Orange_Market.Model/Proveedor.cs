using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Orange_Market.Model
{
    public class Proveedor
    {
        [Key]
        public int Id_Proveedor { get; set; }

        [Required(ErrorMessage = "El campo Nombre es Requerido")]
        public string Nombre_Proveedor { get; set; }

        [Required(ErrorMessage = "El campo Nombre es Requerido")]
        public string Apellido_Proveedor { get; set; }

        [Required(ErrorMessage = "El campo Nombre es Requerido")]
        public int Cedula_Juridica { get; set; }

        [Required(ErrorMessage = "El campo Nombre es Requerido")]
        public string Telefono { get; set; }

        


    }
}
