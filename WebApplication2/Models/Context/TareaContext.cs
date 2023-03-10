using Microsoft.EntityFrameworkCore;

namespace proyectoef.Models.Context
{
    public class TareaContext : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Tarea> Tareas { get; set; }
        public TareaContext(DbContextOptions<TareaContext> options) : base(options) { }
    }
}
