using System;

namespace CONDICIONAL_WHILE_7
{
    class Program
    {
        static void Main(string[] args)
        {   
             #region Area de variavel
            //Escreva um algoritmo que conte de 0 à 10 e de 10 à 0, imprimindo o resultado da contagem na ordem crescente e decrescente.
            Console.Clear();
            int contCrescente = 0, contDecrescente = 10;
            #endregion

            #region Programa
            //início do laço de repetição crescente
            while (contCrescente <= 10)
            {
                //entrada de dados
                Console.WriteLine(contCrescente);
                   
                //contador do laço               
                contCrescente++;  
            }

            //início do laço de repetição decrecente
            while (contDecrescente >= 0)
            {
                //entrada de dados
                Console.WriteLine(contDecrescente);
                   
                //contador do laço               
                contDecrescente--;  
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
