using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Console.Models;

namespace Console.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public void Apresentar()
        {
            System.Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} ano.");
        }
    }
}