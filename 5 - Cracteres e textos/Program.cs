using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 5 caracteres e textos");

        char letra = 'a';
        Console.WriteLine(letra);

        letra = (char)65;
        Console.WriteLine(letra);

        letra = (char) (65 + 1);
        Console.WriteLine(letra);

        letra = (char)(86 + 1);
        Console.WriteLine(letra);

        string primeiraFrase = "Olá esse é me texto ";
        int idade = 35;
        Console.WriteLine(primeiraFrase + idade);

        string vazia = "";
        Console.WriteLine(vazia);

        string cursos = @"Cursos disponiveis:
- Android
- Java
- Ios";
        Console.WriteLine(cursos);

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}

