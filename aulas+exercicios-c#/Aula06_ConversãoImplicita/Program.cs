using System;
using System.Globalization;

namespace Aula06_ConversãoImplicita
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Area de Declaracao de Variaveis
            Console.Clear();
            float notaFiscal, valorNotaComImpostos2;
            double valorNotaComImpostos, notaFiscal2, mediaDosNumeros, mediaDosNumeros2;
            int numero1, numero2;
            #endregion

            #region Passando 8 Bytes (Double) para 4 Bytes (Float)
            //entrada de dados
            Console.WriteLine("************************************************************");
            Console.WriteLine("******* Passando 8 Bytes (Double) para 4 Bytes (Float) - CONVERSÃO EXPLÍCITA *****");
            Console.WriteLine("************************************************************");
            Console.Write("Digite o valor da nota fiscal: ");
            notaFiscal2 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //processamento
            valorNotaComImpostos2 = (float)notaFiscal2 * 1000;
            
            //saida
            Console.WriteLine("\nValor da nota 'sem' imposto R$: " + notaFiscal2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor da nota 'com' imposto R$: " + valorNotaComImpostos2.ToString("F2", CultureInfo.InvariantCulture));
            #endregion

            #region Passando 4 Bytes (Float) para 8 Bytes (Double)
            //entrada de dados
            Console.WriteLine("************************************************************");
            Console.WriteLine("******* Passando 4 Bytes (Float) para 8 Bytes (Double) - CONVERSÃO IMPLÍCITA *****");
            Console.WriteLine("************************************************************");
            Console.Write("Digite o valor da nota fiscal: ");
            notaFiscal = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //processamento
            valorNotaComImpostos = notaFiscal * 1000;
            
            //saida
            Console.WriteLine("\nValor da nota 'sem' imposto R$: " + notaFiscal.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor da nota 'com' imposto R$: " + valorNotaComImpostos.ToString("F2", CultureInfo.InvariantCulture));
            #endregion

            #region Passando 4 Bytes (Int) para 8 Bytes (Double)
            //entrada de dados
            Console.WriteLine("************************************************************");
            Console.WriteLine("******* Passando 4 Bytes (Int) para 8 Bytes (Double) *******");
            Console.WriteLine("************************************************************");
            Console.Write("Digite o valor numero 01...: ");
            numero1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor do numero 02: ");
            numero2 = int.Parse(Console.ReadLine());

            //processamento
            mediaDosNumeros = (numero1 + numero2) /2; // conver
            //processamento EXPLÍCITO (CASTING)
            mediaDosNumeros2 = (double)(numero1 + numero2) /2;  //"(double)" converte para a variavel double. variavel menor int para variavel maior double.

            //saida
            Console.WriteLine("A média IMPLÍCITA " + numero1 + " + " + numero2 + " /2 = " + mediaDosNumeros);
            Console.WriteLine("A média EXPLÍCITA " + numero1 + " + " + numero2 + " /2 = " + mediaDosNumeros2);
            #endregion



            #region  Area de Encerramento do Programa
            Console.WriteLine("\n\nPressione qualquer tecla para sair....");
            Console.ReadKey(); 
            Console.Clear(); 
            #endregion
 
        }
    }
}
