using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2._2.Entities
{
    internal class Numero
    {
        public int Num { get; set; }
        private Random ran = new();
        public Numero() 
        {
            Num = ran.Next(1,100);
        } 
    }
}
/*
Práctica 2. Pares e Impares Crea una aplicación que genere una lista de números aleatorios, posterior a esto la 
aplicación debe de mostrar todos los números pares en una lista y todos los números impares en otra lista. 
 */