using System;
using Console.Models;

class Program
{
    static void Main(string[] args)
    {
        // Lista para armazenar os itens
        List<string> itens = new List<string>();

        // TODO: Solicite os itens ao usuário
        for (int count = 0; count < 3; count++)
        {
            itens.Add(System.Console.ReadLine());
        }

        // Exibe a lista de itens
        System.Console.WriteLine("Lista de itens:");
        foreach (string item in itens)
        {
            System.Console.WriteLine($"- {item}");
        }
    }
}

// class Program
// {
//     static void Main(string[] args)
//     {

//         int saldoTotal = int.Parse(System.Console.ReadLine());
        

//         int valorSaque = int.Parse(System.Console.ReadLine());
        
//         //TODO: Criar as condições necessárias para impressão da saída, vide tabela de exemplos.
        
//         int saldo = saldoTotal - valorSaque;
        
//         if(saldo >= 0)
//         {
          
//           System.Console.WriteLine($"Saque realizado com sucesso! Novo saldo: {saldo}");
//         }else
//           System.Console.WriteLine("Saldo insuficiente. Saque nao realizado!");
        
//     }
// }


// List<string> listaString = new List<string>();

// listaString.Add("SP");
// listaString.Add("MG");
// listaString.Add("BA");
// listaString.Add("RJ");


// foreach (var valor in listaString)
// {
//     System.Console.WriteLine(valor);
   
// }

//  System.Console.WriteLine(listaString.Count);



// int[] arrayInteiro = [4, 6, 8, 10];

// foreach(int valor in arrayInteiro)
//     {
//         System.Console.WriteLine(valor);
//     }





// Calculadora calc = new Calculadora();
// calc.Somar(10, 5);
// calc.Potencia(10,5);






// DateTime dataAtual = DateTime.Now;
// System.Console.WriteLine(dataAtual);

// DateTime dataFutura = DateTime.Now.AddDays(5);
// System.Console.WriteLine(dataFutura);

// System.Console.WriteLine(dataFutura.ToString("dd/MM/yyyy"));

// Pessoa p = new Pessoa();

// p.Nome = "Rahman Brusslo";
// p.Idade = 46;

// p.Apresentar();

