using System;
using System.Globalization;

namespace Aula14_EstruturaWhile
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Declaração de Variaveis
            Console.Clear();
            double raizQuadrada, numero;
            string opcao = "s";
            #endregion

            /*****************************************************************************************************
            * Após fazer a ENTRADA DE DADOS 1 e testá-la, vamos deixá-la comentada e criar a ENTRADA DE DADOS 2.
            * Na ENTRADA DE DADOS 2, vamos criá-la com o laço de repetição WHILE
            *****************************************************************************************************/
            #region Entrada de Dados I
            /*
            //entrada de valor a ser calculado
            Console.Write("Digite um valor para verificar a raiz: ");
            numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //processamento do cálculo da raiz
            raizQuadrada = Math.Sqrt(numero);

            //saida de dados
            Console.WriteLine("A raiz de: " + numero + " é: " + raizQuadrada.ToString("F2", CultureInfo.InvariantCulture));  // F2 = Imprime 2 numeros depois da virgula.

            */
            #endregion

            #region Entrada de Dados II
            //criando um laço de repetição
            while (opcao == "s" || opcao == "S") // || = OU
            {
                //entrada de valor a ser calculado
                Console.Write("Digite um valor para verificar a raiz: ");
                numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                //processamento do cálculo da raiz
                raizQuadrada = Math.Sqrt(numero);

                //saida de dados
                Console.WriteLine("A raiz de: " + numero + " é: " + raizQuadrada.ToString("F2", CultureInfo.InvariantCulture));  // F2 = Imprime 2 numeros depois da virgula.
                
                //verificando se o usuário deseja continuar
                Console.Write("Se pretende continuar a calcular raiz, Digite S ou s: ");
                opcao = Console.ReadLine();
            }
            //mensagem final
            Console.Write("\nVocê saiu do laço. Muito obrigado por usar o programa.");
            #endregion
            

            #region Area de Encerramento do Programa
            Console.WriteLine("\n\nPressione qualquer tecla para sair....");
            Console.ReadKey();
            Console.Clear();
            #endregion
        }
    }
}
