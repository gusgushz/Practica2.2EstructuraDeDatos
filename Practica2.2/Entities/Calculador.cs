using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2._2.Entities
{
    internal class Calculador
    {
        public List<Numero> Numeros = new();
        public List<Numero> NumerosPares = new();
        public List<Numero> NumerosImpares = new();

        public void AgregarNumero(int cantidad)
        {
            for (int i = 0; i < cantidad; i++)
            {
                Numeros.Add(new Numero());
            }
        }
        public void CrearParesNones()
        {
            foreach (Numero numero in Numeros)
            {
                int res = numero.Num % 2;
                if (res == 0)
                {
                    NumerosPares.Add(numero);
                }
                else
                {
                    NumerosImpares.Add(numero);
                }
            }
        }
    }
}
