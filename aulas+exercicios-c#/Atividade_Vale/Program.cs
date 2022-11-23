using System;
using System.Globalization;

namespace Tarefa_calculos2
{
    class Program
    {
        static void Main(string[] args)
        {
            //---------------- Declaração das variáveis -------------

            double saldoTotal, saldoAtual, saldoVale, saldoGasto;
            
            //---------------- Entrada de dados ---------------------
            
            Console.WriteLine("Seu saldo do vale é: R$300 ");
            
            Console.Write("Saldo gasto no mês: ");
            saldoGasto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

         
            //---------------- Área de calculos----------------------- 
           
            saldoVale = 300;
            saldoAtual = (saldoVale - saldoGasto);
            saldoTotal = (saldoVale + saldoAtual);
            
            //----------------- Saída de dados------------------------
            Console.Clear();

            Console.WriteLine("saldo Atual: " + saldoAtual.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("saldo Atual + saldo do próximo mês: " + saldoTotal.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("\n\n");

            Console.ReadKey();




            
        }
    }
}
