using Microsoft.EntityFrameworkCore;
using Orange_Market.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Orange_Market.DA
{
    public class ContextoPrueba : DbContext
    {


        public DbSet<Usuario> Usuario { get; set; }


        public ContextoPrueba(DbContextOptions<ContextoPrueba> options) : base(options)
        {

        }


    }
}
