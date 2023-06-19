using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando Projeto 10 - Calcula poupança");

        double investimento = 1000;
        int mes = 1;

        // quero ver o resultado dos proximos 3 meses
        while (mes <= 12)
        {
            // rendimeto de 0.5% (0.005) ao mes
            investimento = investimento + investimento * 0.005;
            Console.WriteLine("no mes " + mes + " Voce tem saldo de R$ " + investimento);

            //mes = mes + 1;
            //mes++;
            mes += 1;
        }


        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}
