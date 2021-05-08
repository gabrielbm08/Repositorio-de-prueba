using Orange_Market.DA;
using Orange_Market.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orange_Market.BL
{
    public class Repositorio_Cliente
    {
        private ContextoDeBaseDeDatos ElContextoDeBaseDeDatos;

        public Repositorio_Cliente(ContextoDeBaseDeDatos contexto)
        {
            ElContextoDeBaseDeDatos = contexto;
        }
        public void AñadirCliente(Clientes NuevoCliente) {



       
            ElContextoDeBaseDeDatos.Clientes.Add(NuevoCliente);
            ElContextoDeBaseDeDatos.SaveChanges();

        }


        public void EditarCliente(Clientes Cliente) {

            Clientes ClienteParaEditar;

            ClienteParaEditar = ObtenerPorId(Cliente.Id_Cliente);

            ClienteParaEditar.Nombre = Cliente.Nombre;

            ClienteParaEditar.Apellidos = Cliente.Apellidos;

            ClienteParaEditar.Telefono = Cliente.Telefono;

            ClienteParaEditar.Correo_Electronico = Cliente.Correo_Electronico;

            ElContextoDeBaseDeDatos.Clientes.Update(ClienteParaEditar);
            ElContextoDeBaseDeDatos.SaveChanges();
        }

        public Clientes ObtenerPorId(int id)
        {
            Clientes Cliente;
            Cliente = ElContextoDeBaseDeDatos.Clientes.Find(id);

            return Cliente;
        }


        public void EliminarCliente(int Id)

        {
            Clientes Cliente;
            Cliente = ObtenerPorId(Id);
            ElContextoDeBaseDeDatos.Clientes.Remove(Cliente);
            ElContextoDeBaseDeDatos.SaveChanges();

        }


        public List<Clientes> MostrarClientes()
        {
            List<Clientes> LaListaDeClientes;
            LaListaDeClientes = ElContextoDeBaseDeDatos.Clientes.ToList();

            return LaListaDeClientes;
        }



  



        public int CalcularPorcentajeDescuento(decimal Monto_Total) {
            int PorcentajeDescuento = 0;

            if (Monto_Total >= 200000 && Monto_Total <= 399999)
            {


                PorcentajeDescuento = 2;



            }
            else if (Monto_Total >= 400000 && Monto_Total <= 599999) {


                PorcentajeDescuento = 4;



            }

            else if (Monto_Total >= 600000 && Monto_Total <= 799999)
            {


                PorcentajeDescuento = 6;



            }
            else if (Monto_Total >= 800000 && Monto_Total <= 999999)
            {


                PorcentajeDescuento = 8;



            }
            else if (Monto_Total >= 1000000 )
            {


                PorcentajeDescuento = 10;



            }




            return PorcentajeDescuento;

        }

        


    }


}
