using Microsoft.EntityFrameworkCore;

namespace Practica1.Models
{
    public class AlumnoDbContext : DbContext
    {
        public AlumnoDbContext(DbContextOptions<AlumnoDbContext> options) : base(options) { }
        public DbSet<Alumno> Alumnos { get; set; }

    }
}
