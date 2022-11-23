using System;

namespace Aula12_OperadoresLogicos
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Area de Declaracao de Vars
            Console.Clear();

            bool comparacao1, comparacao2, comparacao3, comparacao4, comparacao5, comparacao6, comparacao7;

            #endregion
            
            #region Processamento de Dados
            comparacao1 = 4 != 5;
            comparacao2 = 2 > 3;
            comparacao3 = 2 > 3 && 4 != 5;//FALSE && TRUE = FALSE(2 true = true)
            comparacao4 = 2 > 3 || 4 != 5;//FALSE OU TRUE = TRUE(1 true = true)
            comparacao5 = !(2 > 3) && 4 != 5;
        
            /*
            && (e) - PRECISA QUE TODOS DEEM TRUE PARA RETORNAR TRUE
            || (OU) - SE UMA ÚNICA CONDIÇÃO DER TRUE ELE RETORNA TRUE
            ! (NEGAÇÃO) - Inverte o resultado. ELe nega o valor obtido
            */
            
            //comparando resultado e não número
            comparacao6 = comparacao1 || comparacao3   && comparacao4;
            /*                TRUE ---------FALSE -----------TRUE 
                              ----------------------FALSE
                              --------TRUE8                              */
            comparacao7 = (comparacao1 || comparacao3) && comparacao2;
            /*                 TRUE ---------FALSE ----------FALSE
                                       TRUE -----------------FALSE
                                                  FALSE                  */
            #endregion

            #region Saída de Dados
            Console.WriteLine("======================================================================");
            Console.WriteLine("*** Saída de dados das comparações E(&&) OU(||) ***");
            Console.WriteLine("======================================================================");
            Console.WriteLine("A comparação      [4  != 5]       tem resultado: " + comparacao1);
            Console.WriteLine("A comparação      [4  >  5]       tem resultado: " + comparacao2);
            Console.WriteLine("A comparação  [2 > 3 && 4 != 5]   tem resultado: " + comparacao3);
            Console.WriteLine("A comparação  [2 > 3 || 4 != 5]   tem resultado: " + comparacao4);
            Console.WriteLine("A comparação [!(2 > 3) && 4 != 5] tem resultado: " + comparacao4);
            Console.WriteLine("comparacao1 || comparacao3  && comparacao4 é...: " + comparacao6);
            Console.WriteLine("(comparacao1 || comparacao3) && comparacao2 é..: " + comparacao7);
            #endregion

            #region Area de Encerramento do Programa
            Console.WriteLine("\n\nPressione qualquer tecla para sair....");
            Console.ReadKey();
            Console.Clear();
            #endregion
        }
    }
}
