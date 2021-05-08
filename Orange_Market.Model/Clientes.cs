using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Orange_Market.Model
{
    public class Clientes
    {


        [Key]
        public int Id_Cliente{ get ; set ; }

        [Required(ErrorMessage = "Este Valor es requerido")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Este Valor es requerido")]
        public string Apellidos { get; set; }

        [Required(ErrorMessage = "Este Valor es requerido")]
        public string Correo_Electronico { get; set; }

        [Required(ErrorMessage = "Este Valor es requerido")]
        public int Telefono { get; set; }

      public string Direccion { get; set; }
       

        
       
    }
}
