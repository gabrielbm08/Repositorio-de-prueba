using Orange_Market.DA;
using Orange_Market.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orange_Market.BL
{
    public class Repositorio_Proveedor
    {

        private ContextoDeBaseDeDatos ElContextoDeBaseDeDatos;

        public Repositorio_Proveedor(ContextoDeBaseDeDatos contexto)
        {
            ElContextoDeBaseDeDatos = contexto;
        }
        public void AñadirCliente(Proveedor NuevoProveedor)
        {


            ElContextoDeBaseDeDatos.Proveedor.Add(NuevoProveedor);
            ElContextoDeBaseDeDatos.SaveChanges();

        }


        public void EditarProveedor(Proveedor proveedor)
        {

            Proveedor ProveedorParaEditar;

            ProveedorParaEditar = ObtenerPorId(proveedor.Id_Proveedor);

            ProveedorParaEditar.Nombre_Proveedor = proveedor.Nombre_Proveedor;


            ProveedorParaEditar.Cedula_Juridica = proveedor.Cedula_Juridica;

            ProveedorParaEditar.Telefono = proveedor.Telefono;

            ElContextoDeBaseDeDatos.Proveedor.Update(ProveedorParaEditar);
            ElContextoDeBaseDeDatos.SaveChanges();
        }

        public Proveedor ObtenerPorId(int id)
        {
            Proveedor proveedor;
            proveedor = ElContextoDeBaseDeDatos.Proveedor.Find(id);

            return proveedor;
        }

        public List<Proveedor> MostrarProveedores()
        {
            List<Proveedor> LaListaDeProveedores;
            LaListaDeProveedores = ElContextoDeBaseDeDatos.Proveedor.ToList();

            return LaListaDeProveedores;
        }

        public void EliminarCliente(int Id)
        {
            Proveedor proveedor;
            proveedor = ObtenerPorId(Id);
            ElContextoDeBaseDeDatos.Proveedor.Remove(proveedor);
            ElContextoDeBaseDeDatos.SaveChanges();

        }



    }
}
