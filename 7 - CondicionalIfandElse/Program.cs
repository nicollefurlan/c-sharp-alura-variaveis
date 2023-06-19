using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando projeto 7 - Condicional If e else");

        int idadeJoao = 16;
        int quantidadePessoas = 2;

        if (idadeJoao >= 18)
        {
            Console.WriteLine("Pode entrar!");
        }
        else
        {
            if (quantidadePessoas > 1)
            {
                Console.WriteLine("Opa, ta acompanhado. Pode entrar!");
            }

            else
            {
                Console.WriteLine(" Não Pode entrar!");
            }

        }

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}

