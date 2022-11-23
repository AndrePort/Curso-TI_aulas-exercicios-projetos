using System;

using System.Globalization;


namespace Tarefa_calculos
{
    class Program
    {
        static void Main(string[] args)
        {
         
            //******************** DECLARAÇÃO VARIAVEIS ******************
            
            int contaNumero1, contaNumero2, contaNumero3, contaNumero4, contaNumero5, contaNumero6, contaNumero7, contaNumero8;
            double somaConta1, diviConta2, multConta3, subtConta4;
 
            //******************** DADOS DE ENTRADA **********************
           
            Console.WriteLine("\n------ Insire valores para realizaçao dos cálculos ------\n");
            Console.WriteLine("Adição");
            Console.Write("Valor 1: ");
            contaNumero1 = int.Parse(Console.ReadLine());
            Console.Write("Valor 2: ");
            contaNumero2 = int.Parse(Console.ReadLine());
        
            Console.Write("\n");
            Console.WriteLine("Divisão");
            Console.Write("Valor 1: ");
            contaNumero3 = int.Parse(Console.ReadLine());
            Console.Write("Valor 2: ");
            contaNumero4 = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.Write("\n");
            Console.WriteLine("Muliplicação");
            Console.Write("Valor 1: ");
            contaNumero5 = int.Parse(Console.ReadLine());
            Console.Write("Valor 2: ");
            contaNumero6 = int.Parse(Console.ReadLine());

            Console.Write("\n");
            Console.WriteLine("Subtração");
            Console.Write("Valor 1: ");
            contaNumero7 = int.Parse(Console.ReadLine());
            Console.Write("Valor 2: ");
            contaNumero8 = int.Parse(Console.ReadLine());
            
            //******************** Área de Cálculos **********************
            
            //Cálculo conta de Adição
            somaConta1 = (contaNumero1 + contaNumero2);
            diviConta2 = (contaNumero3 / contaNumero4);
            multConta3 = (contaNumero5 * contaNumero6);
            subtConta4 = (contaNumero7 - contaNumero8);

            //******************** DADOS DE SAÍDA ************************
            
            Console.Clear ();
            Console.WriteLine("\n\n---------- Resutados ----------\n");
            Console.WriteLine("Adição.......: " + somaConta1);
            Console.WriteLine("Divisão......: " + diviConta2.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Multiplicação: " + multConta3);
            Console.WriteLine("Subtração....: " + subtConta4);
            Console.WriteLine("\n\n");

            Console.ReadKey();

        }
    }
}
