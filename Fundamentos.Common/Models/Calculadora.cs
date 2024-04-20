using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Console.Models
{
    public class Calculadora
    {
        public void Somar(int x, int y)
        {
             System.Console.WriteLine($"{x} + {y} = {x + y}");
        }
        
        public void Potencia(int x, int y)
        {
            double z = Math.Pow(x, y);
            System.Console.WriteLine($"{x} ^ {y} = {z}");
        }
    }
}