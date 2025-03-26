using Microsoft.EntityFrameworkCore;

namespace L01P022022AJ650.Models
{
    public class sistema_notasDbContext : DbContext
    {
        public sistema_notasDbContext(DbContextOptions<sistema_notasDbContext> options) : base(options) { }

        public DbSet<facultades> Facultades { get; set; }
        public DbSet<materias> Materias { get; set; }
        public DbSet<departamentos> Departamentos { get; set; }
        public DbSet<alumnos> Alumnos { get; set; }
    }
}
