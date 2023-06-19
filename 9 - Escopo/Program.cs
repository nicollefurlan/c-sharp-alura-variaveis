using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando projeto 7 - Condicional Boolean");

        int idadeJoao = 16;
        int quantidadePessoas = 2;

        bool acompanhado = quantidadePessoas > 1;

        string textoAdicional;

        if (acompanhado == true)
        {
            textoAdicional = "Elu está acompanhado";
        }
        else
        {
            textoAdicional = "Elu não está acompanhado";
        }

        if (idadeJoao >= 18 || acompanhado)
        {
            Console.WriteLine(textoAdicional);
            Console.WriteLine("Pode entrar!");
        }
        else
            Console.WriteLine("Não Pode entrar!");

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}

