using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using WinFormsApp2.models;

namespace WinFormsApp2.database
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Producto> Productos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion101;Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(connectionString);
        }

    }
}
