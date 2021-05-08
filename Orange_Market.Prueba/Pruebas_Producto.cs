using Orange_Market.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orange_Market.Prueba
{
    public class Pruebas_Producto
    {

        public static List<Inventario> Lista_Productos = new List<Inventario>();






        public static void Pruebas_Inventario()
        {

            Inventario Nuevo_Producto = Agregar_Producto();



            Lista_Productos.Add(Nuevo_Producto);

            Console.WriteLine("Producto Agregado: " + Obtener_Producto_PorID(1).ToString());


            Modificar_Producto(Nuevo_Producto);

            Console.WriteLine(" \n Producto Modificado: " + Obtener_Producto_PorID(1).ToString());


            Eliminar_Producto(Nuevo_Producto);


            if (Lista_Productos.Count == 0)
            {


                Console.WriteLine(" \n La lista de Productos está vacia");


            }
            else
            {


                Console.WriteLine(" \n No se eliminó el elemento");

            }





        }



        public static Inventario Agregar_Producto()
        {

            Inventario Producto = new Inventario();

            Producto.Id_Producto = 1;
            Producto.Id_Proveedor = 1;
            Producto.Id_Categoria = 1;
            Producto.Id_Impuesto_Fe = 1;
            Producto.Id_Unidad = 1;
            Producto.Nombre_Articulo ="Leche";
     
            Producto.Precio_Compra = 750;
            Producto.Precio_Venta = 1000;
            

            return Producto;
        }


        public static Inventario Obtener_Producto_PorID(int Id)
        {

            Inventario Producto_Obtenido = new Inventario();

            foreach (Inventario ProductoParaBuscar in Lista_Productos)
            {


                if (ProductoParaBuscar.Id_Producto == Id)
                {


                    Producto_Obtenido = ProductoParaBuscar;



                }



            }

            return Producto_Obtenido;

        }



        public static void Modificar_Producto(Inventario Producto)
        {

            Inventario ProductoParaModificar = Obtener_Producto_PorID(Producto.Id_Producto);

            ProductoParaModificar.Nombre_Articulo = "Queso";

          

            ProductoParaModificar.Precio_Compra = 1000;

            ProductoParaModificar.Precio_Venta = 1350;

            ProductoParaModificar.Id_Unidad = 3;

            ProductoParaModificar.Id_Proveedor = 2;

            ProductoParaModificar.Id_Impuesto_Fe = 3;


            ProductoParaModificar.Id_Categoria = 1;

            



        }


        public static void Eliminar_Producto(Inventario Producto)
        {

            Inventario ProductoParaEliminar = Obtener_Producto_PorID(Producto.Id_Producto);

            Lista_Productos.Remove(ProductoParaEliminar);



        }

    }
}
