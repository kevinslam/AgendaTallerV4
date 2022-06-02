using AgendaTallerV4.Datos;
using AgendaTallerV4.Modelos.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AgendaTallerV4.Pages.Contactos
{
    public class BorrarModel : PageModel
    {
        private readonly AgendaTallerV4DbContext _contexto;
        public BorrarModel(AgendaTallerV4DbContext contexto)
        {
            _contexto = contexto;
        }

        [BindProperty]

        public CrearContactoVM ContactoVm { get; set; }

        public async Task<IActionResult> OnGet(int id)
        {
            ContactoVm = new CrearContactoVM()
            {
                ListaCategorias = await _contexto.Categoria.ToListAsync(),
                Contacto = await _contexto.Contacto.FindAsync(id)
            };
            return Page();
        }

        public async Task<IActionResult> OnPost()
        {
            var ContactoDesdeDb = await _contexto.Contacto.FindAsync(ContactoVm.Contacto.Id);
            if(ContactoDesdeDb == null)
            {
                return NotFound();
            }
           
            _contexto.Contacto.Remove(ContactoDesdeDb);
            await _contexto.SaveChangesAsync();
            return RedirectToPage("Index");
        }

    }
}
