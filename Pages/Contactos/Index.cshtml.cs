using AgendaTallerV4.Datos;
using AgendaTallerV4.Modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AgendaTallerV4.Pages.Contactos
{
    public class IndexModel : PageModel
    {
        private readonly AgendaTallerV4DbContext _contexto;

        public IndexModel(AgendaTallerV4DbContext contexto)
        {
            _contexto = contexto;
        }

        public IEnumerable<Contacto> Contactos { get; set; }
        public async Task OnGet()
        {
            Contactos = await _contexto.Contacto.Include(c => c.Categoria).ToListAsync();
        }
    }
}
