using System.Reflection.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Persistencia;
using Dominio;

namespace FrontEnd//.Pages.Persona
{
    public class DeleteModel : PageModel
    {
        //private static IRepositorioPersona _repo = new  RepositorioPersona(new Persistencia.AplicacionContext());
        
        private readonly IRepositorioPersona _repo;
        
        public DeleteModel(IRepositorioPersona repoPersona)
        {
            _repo =  repoPersona;   
        }        
        public Persona Persona { get; set; }
        public void OnGet(int Id)        
        {
            Persona = _repo.DetailPersona(Id);
        }
        public void OnPost(int Id)
        {
            _repo.DeletePersona(Id); 
        }
    }
}
