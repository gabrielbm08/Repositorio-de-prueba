using Orange_Market.DA;
using Orange_Market.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orange_Market.BL
{
   public class Repositorio_Inventario
    {
        private ContextoDeBaseDeDatos ElContextoDeBaseDeDatos;

        public Repositorio_Inventario(ContextoDeBaseDeDatos contexto)
        {
            ElContextoDeBaseDeDatos = contexto;
        }
        public void AñadirProducto(Inventario NuevoProducto)
        {


            

            ElContextoDeBaseDeDatos.Inventario.Add(NuevoProducto);
            ElContextoDeBaseDeDatos.SaveChanges();

        }


        public void EditarProducto(Inventario Producto)
        {

            Inventario ProductoParaEditar;

            ProductoParaEditar = ObtenerPorId(Producto.Id_Producto);

            ProductoParaEditar.Nombre_Articulo = Producto.Nombre_Articulo;

            ProductoParaEditar.Precio_Compra = Producto.Precio_Compra;
            ProductoParaEditar.Precio_Venta = Producto.Precio_Venta;
        
            ProductoParaEditar.Cantidad = Producto.Cantidad;
            ProductoParaEditar.Id_Categoria = Producto.Id_Categoria;
            ProductoParaEditar.Id_Impuesto_Fe = Producto.Id_Impuesto_Fe;
            ProductoParaEditar.Id_Proveedor =  Producto.Id_Proveedor;
            ProductoParaEditar.Id_Unidad = Producto.Id_Unidad;
        
            
            ElContextoDeBaseDeDatos.Inventario.Update(ProductoParaEditar);
            ElContextoDeBaseDeDatos.SaveChanges();
        }

        public Inventario ObtenerPorId(int id)
        {
            Inventario Inventario;
            Inventario = ElContextoDeBaseDeDatos.Inventario.Find(id);

            return Inventario;
        }

        public List<Inventario> MostrarProductos()
        {
            List<Inventario> LaListaDeProductos;
            LaListaDeProductos = ElContextoDeBaseDeDatos.Inventario.ToList();

            return LaListaDeProductos;
        }
        public void EliminarProducto(int Id)
        {
            Inventario Producto;
            Producto = ObtenerPorId(Id);
            ElContextoDeBaseDeDatos.Inventario.Remove(Producto);
            ElContextoDeBaseDeDatos.SaveChanges();

        }

        public void ActualizarCantidadDeProductos(int id) {

            Inventario ProductoParaActualizar;

            ProductoParaActualizar = ObtenerPorId(id);

            int CantidadParaActualizar = ProductoParaActualizar.Cantidad;

            CantidadParaActualizar = CantidadParaActualizar - 1;

            ProductoParaActualizar.Cantidad = CantidadParaActualizar;

            ElContextoDeBaseDeDatos.Inventario.Update(ProductoParaActualizar);
            ElContextoDeBaseDeDatos.SaveChanges();

        }









    }
}
