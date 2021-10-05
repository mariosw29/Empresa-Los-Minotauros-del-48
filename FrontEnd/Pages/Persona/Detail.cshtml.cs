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
    public class DetailModel : PageModel
    {
        //private readonly IRepositorioPersona _repo;
        private static IRepositorioPersona _repo = new  RepositorioPersona(new AplicacionContext());
        public Persona Persona { get; set; }
        public void OnGet(int Id)        
        {
            Persona = _repo.DetailPersona(Id);
        }
    }
}
