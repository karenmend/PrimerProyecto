using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerProyecto
{
     class Persona
    {
        //ATRIBUTOS ENCAPSULADOS
        public int Edad { get; set; } //Forma de encapsulamiento/Una propiedad encapsulada.
        public string Nombre { get; set; }
        //ATRIBUTOS ENCAPSULADOS

        public Persona(int edad, string nombre)
        {
            this.Edad = edad;

            this.Nombre = nombre;
        
        }

        public Persona()
        {
            Edad = 0;

            Nombre = "";
        }

        public void cumplirAno()
        {
            Edad++;
        }

    }
}
