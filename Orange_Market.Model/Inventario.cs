using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Orange_Market.Model
{
     public class Inventario
    {
        [Key]
        public int Id_Producto { get; set; }

        public int Id_Categoria { get; set; }

        public int Id_Proveedor { get; set; }

        public int Id_Unidad { get; set; }

        public int Id_Impuesto_Fe { get; set; }

        [Required(ErrorMessage = "El campo Nombre es Requerido")]
        public string Nombre_Articulo { get; set; }

        [Required(ErrorMessage = "El campo Nombre es Requerido")]
        public decimal Precio_Venta { get; set; }

        [Required(ErrorMessage = "El campo Nombre es Requerido")]
        public decimal Precio_Compra { get; set; }

        [Required(ErrorMessage = "El campo Nombre es Requerido")]
        public int Cantidad { get; set; }

       

    }
}
