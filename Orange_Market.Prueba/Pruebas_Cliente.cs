using Orange_Market.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orange_Market.Prueba
{
     public class Pruebas_Cliente
    {

        public static List<Clientes> Lista_Clientes = new List<Clientes>();



        


        public static void PruebasParaClientes()
        {

            Clientes Nuevo_Cliente = Agregar_Cliente();



            Lista_Clientes.Add(Nuevo_Cliente);

            Console.WriteLine("Cliente Agregado: " + Obtener_Cliente_PorID(1).ToString());


            Modificar_Cliente(Nuevo_Cliente);

            Console.WriteLine(" \n Cliente Modificado: " + Obtener_Cliente_PorID(1).ToString());


            Eliminar_Cliente(Nuevo_Cliente);


            if (Lista_Clientes.Count == 0)
            {


                Console.WriteLine(" \n La lista de clientes está vacia");


            }
            else
            {


                Console.WriteLine(" \n No se eliminó el elemento");

            }





        }



        public static Clientes Agregar_Cliente()
        {

            Clientes Cliente = new Clientes();
            Cliente.Id_Cliente = 1;
            Cliente.Nombre = "Enrique";
            Cliente.Apellidos = "Gonzales Salas";
            Cliente.Correo_Electronico = "EnriSalas@gmail.com";

            Cliente.Telefono = 89456987;



            return Cliente;
        }


        public static Clientes Obtener_Cliente_PorID(int Id)
        {

            Clientes Cliente_Obtenido = new Clientes();

            foreach (Clientes ClienteParaBuscar in Lista_Clientes)
            {


                if (ClienteParaBuscar.Id_Cliente == Id)
                {


                    Cliente_Obtenido = ClienteParaBuscar;



                }



            }

            return Cliente_Obtenido;

        }



        public static void Modificar_Cliente(Clientes Cliente)
        {

            Clientes ClienteParaModificar = Obtener_Cliente_PorID(Cliente.Id_Cliente);

            ClienteParaModificar.Nombre = "Javier";

            ClienteParaModificar.Apellidos = "Barrates Soto";

            Cliente.Telefono = 96385274;

            ClienteParaModificar.Correo_Electronico = "JaviBarra@outlook.com";



        }


        public static void Eliminar_Cliente(Clientes Cliente)
        {

            Clientes ClienteParaEliminar = Obtener_Cliente_PorID(Cliente.Id_Cliente);

            Lista_Clientes.Remove(ClienteParaEliminar);



        }





    }
}
