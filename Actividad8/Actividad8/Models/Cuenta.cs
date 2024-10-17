using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Actividad8.Models
{
    internal class Cuenta : IComparable
    {
        public int Numero { get; set; }
        public double Saldo { get; set; }
        public DateTime Fecha { get; set; } 
        public Persona Titular { get; set; }
        public Cuenta(int numero,Persona titular) 
        {
            Numero = numero;
            Titular = titular;
        }
        public Cuenta(int numero, Persona titular,DateTime fecha, double saldo)
        {
            Numero = numero;
            Titular = titular;
            Fecha = fecha;
            Saldo = saldo;
        }
        public int CompareTo(object obj)
        {
            if (obj != null && obj is Cuenta)
            {
                return Numero.CompareTo(((Cuenta)obj).Numero);
            }
            return 0;
        }
    }
}
