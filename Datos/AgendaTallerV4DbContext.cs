using AgendaTallerV4.Modelos;
using Microsoft.EntityFrameworkCore;

namespace AgendaTallerV4.Datos
{
    public class AgendaTallerV4DbContext: DbContext
    {
        public AgendaTallerV4DbContext(DbContextOptions<AgendaTallerV4DbContext> options) : base(options)
        {

        }

        //Modelos
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Contacto> Contacto { get; set; }
    }
}
