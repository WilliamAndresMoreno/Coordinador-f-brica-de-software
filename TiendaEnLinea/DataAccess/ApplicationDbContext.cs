using System;
using Microsoft.EntityFrameworkCore;
using TiendaEnLinea.Models;

namespace TiendaEnLinea.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Pedido> Pedidos { get; set; }

        // Puedes agregar aquí otros DbSet para las entidades de tu proyecto
        // ...
    }
}
