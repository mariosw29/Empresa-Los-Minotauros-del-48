using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Persistencia;
using Dominio;

namespace FrontEnd//MyApp.Namespace
{
    public class ListModel : PageModel
    {
        //private readonly IRepositorioCargo _repo;   
        private static IRepositorioCargo _repo = new  RepositorioCargo(new Persistencia.AplicacionContext());
        public IEnumerable<Cargo> Cargos {get; set;}
        public void OnGet()
        {
           Cargos = _repo.ListCargo();    
        }
    }
}
