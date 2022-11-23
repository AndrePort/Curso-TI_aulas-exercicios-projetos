using System;

namespace Aula12_Operadores_Comparativos
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Area de Declaração de Vars
            Console.Clear();

            int a = 10;
            bool comparacao1, comparacao2, comparacao3, comparacao4, comparacao5, comparacao6, comparacao7, comparacao8;
            #endregion

            #region Bloco de Processamento
            //comparação maior menor
            comparacao1 = a < 10;
            comparacao2 = a < 20;
            comparacao3 = a > 10;
            comparacao4 = a > 05;

            //diferença---maior igual---menor igual---igual
            comparacao5 = a != 10;
            comparacao6 = a == 20;
            comparacao7 = a >= 10;
            comparacao8 = a <= 10;
            #endregion

            #region Bloco de Saída de Dados
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("*** BLOCO DE COMPARAÇÃO (MAIOR >) OU (MENOR <) ***");
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("O valor atribuido a variável a é........: " + a);
            Console.WriteLine("Na verificação se [a < 10] o resultado é: " + comparacao1);
            Console.WriteLine("Na verificação se [a < 20] o resultado é: " + comparacao2);
            Console.WriteLine("Na verificação se [a > 10] o resultado é: " + comparacao3);
            Console.WriteLine("Na verificação se [a > 05] o resultado é: " + comparacao4);

            Console.WriteLine("\n---------------------------------------------------------------------");
            Console.WriteLine("*** BLOCO DE COMPARAÇÃO (DIFERENTE !=) (MENOR IGUAL >=) (IGUAL ==) ***");
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("O valor atribuido a variável a é........: " + a);
            Console.WriteLine("Na verificação se [a != 10] o resultado é: " + comparacao5);
            Console.WriteLine("Na verificação se [a == 20] o resultado é: " + comparacao6);
            Console.WriteLine("Na verificação se [a >= 10] o resultado é: " + comparacao7);
            Console.WriteLine("Na verificação se [a <= 05] o resultado é: " + comparacao8);
            #endregion

            #region Area de Encerramento do Programa
            Console.WriteLine("\n\nPressione qualquer tecla para sair....");
            Console.ReadKey();
            Console.Clear();
            #endregion




        }
    }
}
