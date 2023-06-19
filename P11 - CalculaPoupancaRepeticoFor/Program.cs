using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando Projeto 11 - Calcula poupança");


        /*

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
        */


        double investimento = 1000;
       
        for (int mes = 1; mes <= 12; mes = mes + 1) {
            investimento *= 1.005;
            Console.WriteLine("no mes " + mes + " Voce tem saldo de R$ " + investimento);
        }


        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}
