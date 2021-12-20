using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Agencia1.Models;

namespace Agencia1.Models
{
    public class BancoDeDados : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Pacote> Pacotes { get; set; }
             
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            DbContextOptionsBuilder DbContextOptionsBuilder = optionsBuilder.UseSqlServer(connectionString: @"Server=(localdb)\MSSQLLocalDB; DataBase=Agencia1;Integrated Security = True");
        }
             
     
    }


}
