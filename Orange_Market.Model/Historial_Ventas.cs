using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Orange_Market.Model
{
    public class Historial_Ventas
    {
        [Key]
        public int Id_Historia_Venta { get; set; }
        public DateTime Fecha { get; set; }
        public double Total { get; set; }
    }
}
