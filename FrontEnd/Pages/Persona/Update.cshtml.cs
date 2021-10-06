using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Persistencia;
using Dominio;

namespace MyApp.Namespace
{
    public class UpdateModel : PageModel
    {
        private readonly IRepositorioPersona _repo;
        [BindProperty]
        public Persona Persona {get; set;}
        public UpdateModel(IRepositorioPersona repoPersona){
            _repo = repoPersona;
        }
        public void OnGet(int Id) 
        {
            Persona = _repo.DetailPersona(Id); //_repo.UpdatePersona(Id);
            //if (Persona == null)
            //{
               //null;//return RedirectToPage("./NotFound");
            //}
            //else
                //return Pages();
        }

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }

            if (Persona.Id > 0)
            {
                Persona = _repo.UpdatePersona(Persona);
            }            
            return RedirectToPage("./List");
        }
    }
}
