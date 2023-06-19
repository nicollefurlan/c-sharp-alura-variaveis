using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando projeto 6 - Atribuiçao de variaveis");

        int idade = 30;
        int idadeAna = idade;

        Console.WriteLine(idadeAna);

        idade = 25;
        Console.WriteLine(idadeAna);

        string p1 = "10";
        string p2 = "20";
        Console.WriteLine(p1 + p2);


        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}

