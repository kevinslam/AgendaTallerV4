using AgendaTallerV4.Datos;
using AgendaTallerV4.Modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AgendaTallerV4.Pages.Categorias
{
    public class IndexModel : PageModel
    {
        private readonly AgendaTallerV4DbContext _contexto;

        public IndexModel(AgendaTallerV4DbContext contexto)
        {
            _contexto = contexto;
        }

        public IEnumerable<Categoria> Categorias { get; set; }
        public async Task OnGet()
        {
            Categorias = await _contexto.Categoria.ToListAsync();
        }
    }
}
