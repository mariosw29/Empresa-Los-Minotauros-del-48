using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        public IActionResult OnGet(int Id)
        {
            Persona = _repo.DetailPersona(Id);//_repo.UpdatePersona(Id);
            if (Persona == null)
            {
               return RedirectToPage("./NotFound");
            }
            //else
                //return Pages();
        }
    }
}
