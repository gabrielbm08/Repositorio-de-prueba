using Orange_Market.DA;
using Orange_Market.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orange_Market.BL
{
    public class Repositorio_Usuario 
    {
        private ContextoPrueba ElContextoDeBaseDeDatos;

        public Repositorio_Usuario(ContextoPrueba contexto)
        {
            ElContextoDeBaseDeDatos = contexto;
        }
        public void AñadirUsuario(Usuario NuevoUsuario)
        {


            NuevoUsuario.Codigo_Empleado = GenerarCodigoEmpleado();

            ElContextoDeBaseDeDatos.Usuario.Add(NuevoUsuario);
            ElContextoDeBaseDeDatos.SaveChanges();

        }


        public void EditarUsuario(Usuario Usuario)
        {

            Usuario UsuarioParaEditar;

            UsuarioParaEditar = ObtenerPorId(Usuario.Id_Empleado);

            UsuarioParaEditar.Nombre_Usuario = Usuario.Nombre_Usuario;

            UsuarioParaEditar.Contraseña = Usuario.Contraseña;

            ElContextoDeBaseDeDatos.Usuario.Update(UsuarioParaEditar);
            ElContextoDeBaseDeDatos.SaveChanges();
        }

        public Usuario ObtenerPorId(int id)
        {
            Usuario Usuario;
            Usuario = ElContextoDeBaseDeDatos.Usuario.Find(id);

            return Usuario;
        }


    



        public void EliminarUsuario(int Id)
        {
            Usuario UsuarioParaEliminar;
            UsuarioParaEliminar = ObtenerPorId(Id);

            ElContextoDeBaseDeDatos.Usuario.Remove(UsuarioParaEliminar);
            ElContextoDeBaseDeDatos.SaveChanges();

        }

        public List<Usuario> MostrarUsuarios()
        {
            List<Usuario> LaListaDeUsuarios;
            LaListaDeUsuarios = ElContextoDeBaseDeDatos.Usuario.ToList();

            return LaListaDeUsuarios;
        }
        public string GenerarCodigoEmpleado() {

            string Codigo_empleado = "";
           
            var seed = Environment.TickCount;
            var random = new Random(seed);

            for (int i = 0; i <= 5; i++)
            {
                var value = random.Next(0, 10);


                Codigo_empleado += value;
            }

  
            return Codigo_empleado;
        }



        public List<Usuario> ListarUsuario(int id)
        {
            var resultado = from c in ElContextoDeBaseDeDatos.Usuario
                            

                            select c;

            return resultado.ToList();
        }




    }
}
