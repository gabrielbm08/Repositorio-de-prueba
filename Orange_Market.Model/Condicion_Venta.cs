using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Orange_Market.Model
{
    public class Condicion_Venta
    {
        [Key]
        public int Id_Condicion_Venta { get; set; }
        public string Descripcion { get; set; }

    }
}
