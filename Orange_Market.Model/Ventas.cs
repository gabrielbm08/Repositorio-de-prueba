using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Xml;

namespace Orange_Market.Model
{
    public class Ventas
    {
        [Key]
        public int Id_Venta { get; set; }

        public int Id_Empleado { get; set; }

        public int Id_Medio_Pago { get; set; }

        public int Id_Cliente { get; set; }

        public int Id_Condicion_Venta { get; set; }

        public int Id_Caja { get; set; }

        public int Id_Producto { get; set; }

        public double Subtotal { get; set; }

        public double Monto_IVA { get; set; }

        public double Total { get; set; }

        public DateTime Fecha_Hora_Compra { get; set; }

        public string Clave { get; set;  }

        public int Codigo_Moneda { get; set;  }

        
        public XmlDocument Xml_Factura { get; set; }

        public string Codigo_Impuesto { get; set; }

        public string Estado { get; set; }



        //Datos Inicializados con la información de la empresa
        [NotMapped]

        public string Id_Tributacion = "000000000000"; //Pendiente de inventar
        [NotMapped]
        public string Descripcion = "Venta de productos";
        [NotMapped]
        public string Correo_Empresa = "Gerencia_OM@orangemarket.com";
        [NotMapped]
        public int Id_provincia = 5;
        [NotMapped]
        public int Id_Distrito = 1;
        [NotMapped]
        public int Id_Canton = 1;
        [NotMapped]
        public int Id_Barrio = 1;
        [NotMapped]
        public string Usuario_Hacienda = "UsuarioxD";//Pendiente de inventar
        [NotMapped]
        public string Clave_Hacienda = "ClaveXD"; //Pendiente de inventar
        [NotMapped]
        public string Pin_Certifica_Hacienda = "Pinxd"; //Pendiente de inventar
        [NotMapped]
        public string Llave_Criptografica = "llavexD"; //Pendiente de inventar

        [NotMapped]
        public string Codigo_actividad = "0"; //Pendiente de consultar



        //Variables para el numero consecutivo
        [NotMapped]
        public string Sucursal = "001";

        [NotMapped]
        public string Punto_De_Venta = "00001";
        [NotMapped]
        public string Tipo_De_Documento = "01";
        [NotMapped]
        public string Comprobante { get; set; } //usa el ID Venta
        [NotMapped]
        public string Consecutivo { get; set; } //Esta variable toma el valor de las anteriores pero combinadas


        //Variables para formar la clave

        [NotMapped]
        public string Codigo_Pais = "506";
        [NotMapped]
        public string Dia { get; set; } //se obtiene del sistema
        [NotMapped]
        public string Mes { get; set; }//se obtiene del sistema
        [NotMapped]
        public string Año { get; set; } //se obtiene del sistema
        [NotMapped]
        public string Identificacion_Juridica = "000000000000";//Pendiente de inventar
        [NotMapped]
        public string Tipo_comprobante = "1";
        [NotMapped]
        public string Codigo_Seguridad = "00000000"; // pendiente de inventar
        
        [NotMapped]
        public string Normativa { get; set; } //buscar
        [NotMapped]
        public DateTime Fecha_Normativa { get; set; } //buscar




    }
}
