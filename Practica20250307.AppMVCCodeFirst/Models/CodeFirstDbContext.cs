using Microsoft.EntityFrameworkCore;

namespace Practica20250307.AppMVCCodeFirst.Models
{
    public class CodeFirstDbContext : DbContext
    {

        public CodeFirstDbContext(DbContextOptions<CodeFirstDbContext> options) : base(options) { }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Alumno> Alumnos { get; set; }


    }
}
