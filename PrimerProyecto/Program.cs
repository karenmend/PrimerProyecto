﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerProyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = 
                new Persona(25, "José");
            Console.WriteLine(persona1.Nombre +
                " tiene " + persona1.Edad + " años ");

            persona1.cumplirAno();
            Console.WriteLine("Ahora " +  persona1.Nombre + " tiene " + persona1.Edad + " años.");

            Console.ReadLine();
        }
    }
}
