using AgendaTallerV4.Datos;
using AgendaTallerV4.Modelos.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AgendaTallerV4.Pages.Contactos
{
    public class CrearModel : PageModel
    {
        private readonly AgendaTallerV4DbContext _contexto;

        public CrearModel(AgendaTallerV4DbContext contexto)
        {
            _contexto = contexto;
        }

        [BindProperty]

        public CrearContactoVM ContactoVm { get; set; }
        public async Task<IActionResult> OnGet()
        {
            ContactoVm = new CrearContactoVM()
            {
                ListaCategorias = await _contexto.Categoria.ToListAsync(),
                Contacto = new Modelos.Contacto()
            };
            return Page();
        }

        public async Task<IActionResult> OnPost()
        {

            //ContactoVm.ListaCategorias = await _contexto.Categoria.ToListAsync();

            await _contexto.Contacto.AddAsync(ContactoVm.Contacto);
            await _contexto.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }
}
