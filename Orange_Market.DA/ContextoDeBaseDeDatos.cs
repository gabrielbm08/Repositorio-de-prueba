using Microsoft.EntityFrameworkCore;
using Orange_Market.Model;
using System;
using System.Collections.Generic;
using System.Text;


namespace Orange_Market.DA
{
    public class ContextoDeBaseDeDatos : DbContext
    {

        

        public DbSet<Clientes> Clientes { get; set; }

        public DbSet<Condicion_Venta> Condicion_Ventas { get; set; }

        public DbSet<Ventas> Ventas { get; set; }

        public DbSet<Historial_Ventas> Historial_Ventas { get; set; }

 

        public DbSet<Inventario> Inventario { get; set; }

   

        public DbSet<Medio_Pago_Fe> Medio_Pago_Fe { get; set; }

       

        public DbSet<Proveedor> Proveedor { get; set; }

        
        public DbSet<Tipo_Empleado> Tipo_Empleado { get; set; }


        public DbSet<Usuario> Usuario { get; set; }

        public ContextoDeBaseDeDatos(DbContextOptions<ContextoDeBaseDeDatos> options) : base(options)
        {

        }


    }
}
