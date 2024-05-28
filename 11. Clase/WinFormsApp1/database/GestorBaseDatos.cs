using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.models;

namespace WinFormsApp1.database
{
    public class GestorBaseDatos : DbContext
    {
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //string connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaClase11;Trusted_Connection=True;";
            string connectionString = @"Server=localhost\SQLEXPRESS1;Database=SistemaGestion11;Trusted_Connection=True;Integrated Security=true;TrustServerCertificate=True;";

            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
