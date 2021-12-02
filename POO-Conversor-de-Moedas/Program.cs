//Frederico Guilherme Camilli Proença RA:200925

using System;
using System.Globalization;
using System.Threading;

namespace POO_Conversor_de_Moedas
{
    //Programa principal com o qual o usuário interagirá.
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de um novo CultureInfo CIBR, que utiliza o pt-BR como base.
            CultureInfo CIBR = new ("pt-BR");
            //Mudança do Culture utilizado no programa para o CIBR.
            Thread.CurrentThread.CurrentCulture = CIBR;
            //Declaração das variáveis double cotaDolar e valorDolar, que serão utilizadas para realizar a conversão presente em CDM.
            double cotaDolar, valorDolar;
            //Interação com o usuário sobre a cotação do dólar.
            //Para achar a cota do dólar, visite https://economia.uol.com.br/cotacoes/cambio/. Valor atual em 1/12/2021, às 17:00 = 5,670.
            Console.Write("Qual é a cotação do dólar? $");
            //Inserção pelo usuário sobre a cotação do dólar.
            cotaDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Interação com o usuário sobre a quantidade de dólares a serem comprados.
            Console.Write("Quantos dólares você irá comprar? $");
            //Inserção pelo usuário sobre a quantidade de dólares a serem comprados.
            valorDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Declaração de um novo CDM conversor, que realizará os métodos presentes em CDM.
            CDM conversor = new (cotaDolar, valorDolar);
            //Uso do método CalculoRealETotal, declarado em CDM.
            conversor.CalculoRealETotal();
            //Exibição do valor pago em reais, a taxa em porcentagem do IOF, e o valor total pago em reais.
            Console.WriteLine(conversor.ToString());
        }
    }
}
