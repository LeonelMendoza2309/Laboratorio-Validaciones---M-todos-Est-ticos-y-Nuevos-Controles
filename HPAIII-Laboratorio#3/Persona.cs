using System;
using System.Collections.Generic;
using System.Text;

namespace EjemploGrid
{
    public class Persona
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Correo { get; set; }
        public DateTime FechaNacmiento { get; set; }
        public decimal Salario { get; set; }
    }
}