using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Orange_Market.Model
{
    public class Tipo_Empleado
    {


        [Key]
        public int Id_Tipo_Empleado { get; set ; }

        [Required(ErrorMessage = "Este Valor es requerido")]
        public string Descripcion { get ; set; }


    }
}
