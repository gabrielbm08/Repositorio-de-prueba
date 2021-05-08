using Orange_Market.DA;
using Orange_Market.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Orange_Market.BL
{
    public class Repositorio_Venta
    {
        private ContextoDeBaseDeDatos ElContextoDeBaseDeDatos;

        List<Inventario> ListaTemporalDeProductos = new List<Inventario>();

        public Repositorio_Venta(ContextoDeBaseDeDatos contexto)
        {
            ElContextoDeBaseDeDatos = contexto;
        }




   



        public List<Ventas> MostrarVentas()
        {
            List<Ventas> LaListaDeVentas;
            LaListaDeVentas = ElContextoDeBaseDeDatos.Ventas.ToList();

            return LaListaDeVentas;
        }


        public Ventas ObtenerUltimaVenta()
        {

            Ventas UltimaVenta;


            List<Ventas> LaListaDeVentas;
            LaListaDeVentas = ElContextoDeBaseDeDatos.Ventas.ToList(); ;

            int UltimoElemento = LaListaDeVentas.Count();

            UltimaVenta = LaListaDeVentas[UltimoElemento - 1];

              
            
            return UltimaVenta;
        }


        

        public string EscanearProducto()
        {

            //Este método se llama escanear producto, pero en realidad lo que hará es obtener un producto aleatorio de la base de datos
            //y generará una cantidad aleatoria para simular una compra

           //Yerri está haciendo este método

            return "";
        }







        //Gabriel-Yerri





        //Guardar Venta


        public decimal GenerarTotal(decimal Subtotal, decimal MontoIva, decimal Descuento ) {

            decimal MontoTotal;


            MontoTotal = (Subtotal + MontoIva) - Descuento;

            return MontoTotal;


        }

       

        //General Subtotal venta (Sumar todo lo de la lista temporal de productos)
        public decimal GenerarSubtotal(List<Inventario> ListaTemporalProductos) {

            decimal Subtotal =0;


            foreach (Inventario Producto in ListaTemporalProductos) {




                Subtotal += Producto.Precio_Venta;
            
            
            }

            return Subtotal;
        }





      


        
  



        //Metodos para el historial




        public void GenerarCierreCaja() { 
        
        
        
        
        
        
        
        
        
        
        
        }





    }
}
