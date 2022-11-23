using System;

namespace Aula18_Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Área de Variáveis
            Console.Clear();
            int linha, coluna, posicao = 0;
            int[,] idadeUsuarios = new int[3,3];
            int[,] idadeUsuarios2 = new int[2,2];
            string[,] nomeUsuarios = new string[2,2];
            #endregion

            #region Executando a Matriz 1
            Console.WriteLine("Vamos começar a digitação da LINHA: " + posicao);
            for(linha = 0; linha < 3; linha++)
            {
                for(coluna = 0; coluna <3; coluna++)
                {
                    Console.Write("Digite a idade na posição: [" + linha + "][" + coluna + "]: ");
                    idadeUsuarios[linha, coluna] = int.Parse(Console.ReadLine());

                }
                posicao++;
                if(posicao < 3)
                {
                    Console.WriteLine("\nIniciando a digitação da linha: " + posicao);
                }
                
            }

            #endregion
            
            #region Imprimindo a Matriz 1
            Console.WriteLine("\n\n***IMPRIMINDO RESULTADO DA DIGITAÇÃO ***");
            for(linha = 0; linha < 3; linha++)
            {
                for(coluna = 0; coluna <3; coluna++)
                {
                    Console.WriteLine("Imprimindo a idade " + idadeUsuarios[linha, coluna] + " na posição: [" + linha + "][" + coluna + "] ");

                }
            }
            #endregion

            #region Executando a Matriz 2
            for(linha = 0; linha < 2; linha++)
            {
                for(coluna = 0; coluna < 2; coluna++)
                {
                    Console.Write("Digite o nome na posição: [" + linha + "][" + coluna + "]: ");
                    nomeUsuarios[linha, coluna] = Console.ReadLine();
                    Console.Write("Digite a idade na posição: [" + linha + "][" + coluna + "]: ");
                    idadeUsuarios2[linha, coluna] = int.Parse(Console.ReadLine());
                }
            }

            #endregion
            
            #region Imprimindo a Matriz 2
            Console.WriteLine("\n\n***IMPRIMINDO RESULTADO DA DIGITAÇÃO ***");
            for(linha = 0; linha < 2; linha++)
            {
                for(coluna = 0; coluna < 2; coluna++)
                {
                    Console.WriteLine(nomeUsuarios[linha, coluna] + " sua idade é: " + idadeUsuarios2[linha, coluna]);

                }
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
