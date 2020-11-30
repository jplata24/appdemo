using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
namespace App.Api.Modelos
{
    public class Escuela
    {
        public int Id {get; set;}

        public string Nombre { get; set;}

        public string Ciudad {get; set;}

        public string Departamento {get; set;}

        public ICollection <Profesor> Profesores {get; set;}
        

    }
}
