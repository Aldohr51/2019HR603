using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using _2019HR603.Models;
namespace _2019HR603
{
    public class _2019HR603Context : DbContext
    {
        public _2019HR603Context(DbContextOptions<_2019HR603Context> options) : base(options)
        {
            
        }
        public DbSet<equipos> equipos {get; set;}
        public DbSet<estados_equipo> estados_equipo {get; set;}
        public DbSet<marcas> marcas {get; set;}
        public DbSet<tipo_equipo> tipo_equipo {get; set;}
    }
}