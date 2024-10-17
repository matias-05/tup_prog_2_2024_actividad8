using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad8.Models
{
    internal class Banco
    {
        List<Cuenta> cuentas = new List<Cuenta>();
        List<Persona> clientes = new List<Persona>();
        public int CantidadClientes { get { return clientes.Count; } }
        public int CantidadCuentas { get { return cuentas.Count; } }
        public Cuenta this[int idx]
        {
            get
            {
                if (idx > 0 && idx < cuentas.Count)
                {
                    return cuentas[idx];
                }
                return null;
            }
        }
        public Cuenta VerCuentaPorNumero(int numCuenta)
        {
            cuentas.Sort();
            Persona b = new Persona(0,"");
            Cuenta buscada = new Cuenta(numCuenta,b);
            int idx = cuentas.BinarySearch(buscada);
            return cuentas[idx];
        }
        public Persona VerClientePorDNI(int dni)
        {
            clientes.Sort();
            Persona buscar = new Persona(dni, "");
            int idx = clientes.BinarySearch(buscar);
            return clientes[idx];
        }
        public Cuenta AgregarCuenta(int numCuenta, int dni, string nombre)
        {
            Persona p = VerClientePorDNI(dni);
            if (p==null)
            {
                p = new Persona(dni, nombre);
                clientes.Add(p);
            }
            Cuenta c = VerCuentaPorNumero(numCuenta);
            if (c == null)
            {
                c = new Cuenta(numCuenta,p);
                cuentas.Add(c);
            }
            return c;
        }
    }
}
