using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Orange_Market.Model
{
    public class Usuario
    {

        [Key]
        public int Id_Empleado { get; set; }
        public int Id_Tipo_Empleado { get; set ; }

        public string Codigo_Empleado { get; set; }

        [Required(ErrorMessage = "Este Valor es requerido")]
        public string Nombre_Usuario { get ; set ; }

        [Required(ErrorMessage = "Este Valor es requerido")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Este Valor es requerido")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "Este Valor es requerido")]
        public string Contraseña { get ; set; }
        [Required(ErrorMessage = "Este Valor es requerido")]
        public string Correo_Empresa { get ; set ; }


        





    }
}
