using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Persistencia;
using Dominio;

namespace FrontEndd//MyApp.Namespace
{
    public class ListModel : PageModel
    {
        //private readonly IRepositorioCargo _repo;   
        private static IRepositorioProveedor _repo = new  RepositorioProveedor(new Persistencia.AplicacionContext());
        public IEnumerable<Proveedor> Proveedors {get; set;}
        public void OnGet()
        {
           Proveedors = _repo.ListProveedor();    
        }
    }
}
