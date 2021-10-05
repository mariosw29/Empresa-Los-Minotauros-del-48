using System.ComponentModel.DataAnnotations;

namespace Dominio
{
    public class Persona
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }
        [Required]
        public int Cedula { get; set; }
        [Required]
        public string Email { get; set; }      
    }
}