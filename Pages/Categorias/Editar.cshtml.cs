using AgendaTallerV4.Datos;
using AgendaTallerV4.Modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AgendaTallerV4.Pages.Categorias
{
    public class EditarModel : PageModel
    {
        private readonly AgendaTallerV4DbContext _contexto;

        public EditarModel(AgendaTallerV4DbContext contexto)
        {
            _contexto = contexto;
        }

        [BindProperty]
        public Categoria Categoria { get; set; }
        public async void OnGet(int id)
        {
            Categoria = await _contexto.Categoria.FindAsync(id);
        }

        public async Task<IActionResult> OnPost()
        {
            var CategoriaDesdeBd = await _contexto.Categoria.FindAsync(Categoria.Id);
            CategoriaDesdeBd.Nombre = Categoria.Nombre;
            CategoriaDesdeBd.FechaCreacion = Categoria.FechaCreacion;

            await _contexto.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }
}
