using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando Projeto 13 - Encadeando for");

        // * usar for para preenchimento de desenho

        for (int contadorLinhas = 0; contadorLinhas < 10; contadorLinhas++)
        {
            for (int contadorColuna = 0; contadorColuna < 10; contadorColuna++)
            {
                Console.Write("*");
                if (contadorColuna >= contadorLinhas)
                {
                    break;
                }
            }
                Console.WriteLine();
        }

        for (int contadorLinhas = 0; contadorLinhas < 10; contadorLinhas++)
        {
            for (int contadorColuna = 0; contadorColuna <= contadorLinhas; contadorColuna++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }



        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}

