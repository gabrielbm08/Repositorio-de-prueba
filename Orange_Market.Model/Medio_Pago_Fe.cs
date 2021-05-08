using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Orange_Market.Model
{
    public class Medio_Pago_Fe
    {
        [Key]
        public int Id_Medio_Pago { get; set; }
        public string Descripcion { get; set; }
    }
}
