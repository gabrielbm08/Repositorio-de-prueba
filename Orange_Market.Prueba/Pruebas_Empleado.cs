using Orange_Market.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orange_Market.Prueba
{
    public class Pruebas_Empleado
    {

        public static List<Usuario> Lista_Usuarios = new List<Usuario>();



        public static void Pruebas_Usuario()
        {

            Usuario Nuevo_Usuario = Agregar_Usuario();



            Lista_Usuarios.Add(Nuevo_Usuario);

            Console.WriteLine("Usuario Agregado: " + Obtener_Usuario_PorID(1).ToString());


            Modificar_Usuario(Nuevo_Usuario);

            Console.WriteLine(" \n Cliente Modificado: " + Obtener_Usuario_PorID(1).ToString());


            Eliminar_Usuario(Nuevo_Usuario);


            if (Lista_Usuarios.Count == 0)
            {


                Console.WriteLine(" \n La lista de Usuarios está vacia");


            }
            else
            {


                Console.WriteLine(" \n No se eliminó el elemento");

            }





        }



        public static Usuario Agregar_Usuario()
        {

            Usuario Usuario = new Usuario();
            Usuario.Id_Empleado = 1;
            Usuario.Nombre_Usuario = "Steven Lopez";
            Usuario.Id_Tipo_Empleado = 1;
            Usuario.Correo_Empresa = "SLopez@OrangeMarket.com";
            Usuario.Contraseña = "asd1234";
            Usuario.Codigo_Empleado = "125054";
           

            return Usuario;
        }


        public static Usuario Obtener_Usuario_PorID(int Id)
        {

            Usuario Usuario_Obtenido = new Usuario();

            foreach (Usuario UsuarioParaBuscar in Lista_Usuarios)
            {


                if (UsuarioParaBuscar.Id_Empleado == Id)
                {


                    Usuario_Obtenido = UsuarioParaBuscar;



                }



            }

            return Usuario_Obtenido;

        }



        public static void Modificar_Usuario(Usuario Usuario)
        {

            Usuario UsuarioParaModificar = Obtener_Usuario_PorID(Usuario.Id_Empleado);

            UsuarioParaModificar.Nombre_Usuario = "Jorge Castro";

            UsuarioParaModificar.Id_Tipo_Empleado = 2;

            UsuarioParaModificar.Correo_Empresa = "JCastro@OrangeMarket.com";


            UsuarioParaModificar.Contraseña = "ghj4546";



        }


        public static void Eliminar_Usuario (Usuario Usuario)
        {

            Usuario UsuarioParaEliminar = Obtener_Usuario_PorID(Usuario.Id_Empleado);

            Lista_Usuarios.Remove(UsuarioParaEliminar);



        }


    }
}
