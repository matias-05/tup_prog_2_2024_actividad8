using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad8.Models
{
    internal class Persona : IComparable
    {
        public int Dni { get; set; }
        public string Nombre { get; set; }
        public Persona(int dni, string nombre) 
        {
            Dni = dni;
            Nombre = nombre;
        }
        public int CompareTo(object obj)
        {
            if (obj != null && obj is Persona)
            {
                return Dni.CompareTo(((Persona)obj).Dni);
            }
            return 0;
        }
    }
}
