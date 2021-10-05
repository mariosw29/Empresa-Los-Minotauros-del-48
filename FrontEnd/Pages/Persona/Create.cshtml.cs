using System.Security.Cryptography.X509Certificates;
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
    public class CreateModel : PageModel
    {
        private readonly IRepositorioPersona _repo;

        public Persona Persona {get; set;}
        
        public CreateModel(IRepositorioPersona repo)
        {
            _repo = repo;
        }
        
        public void OnGet()        
        {            
        }

        public void OnPost(Persona persona)
        {
            _repo.AddPersona(persona);
        }
    }
}
