using System;

namespace CONDICIONAL_WHILE_6
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Area de Variavel
            string nomes;
            int cont = 1;
            Console.Clear();
            #endregion  

            #region Programa
            while (cont <= 5)
            {
                Console.WriteLine("Digite o nome " + cont + ":");
                nomes = Console.ReadLine();
                Console.WriteLine("O " + cont + "º nome digitado foi: " + nomes);
                cont = cont + 1;
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
