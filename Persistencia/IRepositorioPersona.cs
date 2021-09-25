using System;
using Dominio;
using System.Collections.Generic;

namespace Persistencia
{
    public interface IRepositorioPersona
    {
        IEnumerable<Persona> ListPersona();        
        Persona AddPersona(Persona Persona);        
        Persona UpdatePersona(Persona persona);
        Boolean DeletePersona(int id_persona);
        Persona DetailPersona(int id_persona);  
    }
}