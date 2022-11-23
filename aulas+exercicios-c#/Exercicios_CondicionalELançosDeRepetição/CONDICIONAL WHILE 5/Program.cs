using System;

namespace CONDICIONAL_WHILE_5
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Area de variavel
            Console.Clear();
            int numero, cont = 0, resultadoTabudada;

            #endregion

            #region Programa
            //entrada de dados de um valor numérico
            Console.WriteLine("===========Tabuada===========");
            Console.Write("Digite um numero: ");
            numero = int.Parse(Console.ReadLine());
            //início do laço de repetição

            while (cont <= 10)
            {
                resultadoTabudada = numero * cont;

                Console.WriteLine(numero + " X " + cont + " = " + resultadoTabudada);
                cont++;
                Console.ReadKey();
            }
            #endregion

            #region Encerramento
            Console.WriteLine("\n\nPressione qualquer tecla para sair....");
            Console.ReadKey();
            Console.Clear();

            #endregion
        }
    }
}
