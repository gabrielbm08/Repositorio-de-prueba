using Orange_Market.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orange_Market.Prueba
{
    public class Pruebas_Proveedor
    {

        public static List<Proveedor> Lista_Proveedores = new List<Proveedor>();



       


        public static void PruebasParaProveedor()
        {

            Proveedor Nuevo_Proveedor = Agregar_Proveedor();



            Lista_Proveedores.Add(Nuevo_Proveedor);

            Console.WriteLine("Proveedor Agregado: " + Obtener_Proveedor_PorID(1).ToString());


            Modificar_Proveedor(Nuevo_Proveedor);

            Console.WriteLine(" \n Proveedor Modificado: " + Obtener_Proveedor_PorID(1).ToString());


            Eliminar_Proveedor(Nuevo_Proveedor);


            if (Lista_Proveedores.Count == 0)
            {


                Console.WriteLine(" \n La lista de proveedores está vacia");


            }
            else
            {


                Console.WriteLine(" \n No se eliminó el elemento");

            }





        }



        public static Proveedor Agregar_Proveedor()
        {

            Proveedor Proveedor = new Proveedor();
            Proveedor.Id_Proveedor = 1;
            Proveedor.Nombre_Proveedor = "Richly";
            Proveedor.Cedula_Juridica = 987654321;
           
           



            return Proveedor;
        }


        public static Proveedor Obtener_Proveedor_PorID(int Id)
        {

            Proveedor Proveedor_Obtenido = new Proveedor();

            foreach (Proveedor ProveedorParaBuscar in Lista_Proveedores)
            {


                if (ProveedorParaBuscar.Id_Proveedor == Id)
                {


                    Proveedor_Obtenido = ProveedorParaBuscar;



                }



            }

            return Proveedor_Obtenido;

        }



        public static void Modificar_Proveedor(Proveedor proveedor)
        {

            Proveedor ProveedorParaModificar = Obtener_Proveedor_PorID(proveedor.Id_Proveedor);

            ProveedorParaModificar.Nombre_Proveedor = "Del Monte SA";

            ProveedorParaModificar.Cedula_Juridica = 123456789;

           


        }

        public static void Eliminar_Proveedor(Proveedor proveedor)
        {

            Proveedor ProveedorParaEliminar= Obtener_Proveedor_PorID(proveedor.Id_Proveedor);

            Lista_Proveedores.Remove(ProveedorParaEliminar);



        }


    }
}
