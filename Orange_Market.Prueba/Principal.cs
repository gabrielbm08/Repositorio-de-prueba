using Orange_Market.DA;
using Orange_Market.Model;
using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace Orange_Market.Prueba
{
    class Principal
    {
     
        static void Main() {



            Console.WriteLine("Hola");

            //Pruebas_Cliente.PruebasParaClientes();
            //Pruebas_Proveedor.PruebasParaProveedor();
            //Pruebas_Empleado.Pruebas_Usuario();
            //Pruebas_Producto.Pruebas_Inventario();
            //GenerarNumeroEmpleado("");

            Ventas NuevaVenta = new Ventas();

            NuevaVenta.Id_Venta = 1;
            NuevaVenta.Id_Caja = 1;
            NuevaVenta.Id_Cliente = 1;
            NuevaVenta.Id_Condicion_Venta = 1;
            NuevaVenta.Id_Medio_Pago = 1;
            NuevaVenta.Clave = "123456786543";
      
            NuevaVenta.Subtotal = 12314;
            NuevaVenta.Monto_IVA = 123;
           


          

        }

        static void GenerarNumeroEmpleado(string dato)
        {
            string Codigo_empleado= dato;
            var seed = Environment.TickCount;
            var random = new Random(seed);

            for (int i = 0; i <= 5; i++)
            {
                var value = random.Next(0, 10);


                Codigo_empleado += value;
            }



            Console.WriteLine(Codigo_empleado);

        }

       


    }
}
