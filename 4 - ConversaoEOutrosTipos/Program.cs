using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("4 - Projeto Conversão");

        double salario = 3000.15;
        Console.WriteLine(salario);

        int salarioInteiro = (int)salario; //para que aceita o salario cast
        Console.WriteLine(salarioInteiro);

        long salariox = 2000000000000000; // long  é um tipode variavel  com valores de 64 bits
        Console.WriteLine(salariox);    

        short salarioy = 15000; // pequenos valores
        Console.WriteLine(salarioy);

        float altura = 1.62f;
        Console.WriteLine(altura);

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}

