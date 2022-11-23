using System;

namespace Aula17_Vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Area de variáveis do Vetor SEM TAMANHO DEFINIDO
            Console.Clear();
            int cont, cont2 = 1, qtdAlunos = 0;

            #endregion

            #region Testando os Vetores SEM TAMANHO DEFINIDO
            //entrando com dados para iniciar o vetor
            Console.Write("Quantos alunos tem na escola? ");
            qtdAlunos = int.Parse(Console.ReadLine());

            //declarando vetor com o tamanho definido pelo usuário
            int[] idadeAluno = new int[qtdAlunos];

            //perguntando a idade de todos os alunos
            for(cont = 0; cont < idadeAluno.Length; cont++ )  //Length determina 
            {
                Console.Write("Digite a Idade do Aluno " + cont2 + ": ");
                idadeAluno[cont] = int.Parse(Console.ReadLine());
                cont2++;
            }
            
            //atribuindo 1 ao cont2
            cont2 = 1;

            //perguntando a idade de todos os alunos
            for(cont = 0; cont < idadeAluno.Length; cont++ )
            {
                Console.WriteLine("A Idade do Aluno " + cont2 + " é: " + idadeAluno[cont]);
                cont2++;
            }
            #endregion
            /*
            #region Area de variáveis do Vetor COM TAMANHO DEFINIDO
            //declarando vetores strings e int tamanho 5
            int[] idade = new int[5];
            string[] nomePessoa = new string[5];

            #endregion 

            #region Testando os Vetores COM TAMANHO DEFINIDO
            // atribuindo q ao cont2
            cont2 = 1;

            //lendo os vetores
            for(cont = 0; cont < idade.Length; cont ++)
            {
                Console.Write("\nDigite o " + cont2 + "º nome: ");
                nomePessoa[cont] = Console.ReadLine();
                Console.Write(nomePessoa[cont] + ", qual sua idade? ");
                idade[cont] = int.Parse(Console.ReadLine());
                
                cont2++;
            }

            //imprimindo
            for(cont = 0; cont < idade.Length; cont ++)
            {
                Console.WriteLine(nomePessoa[cont] + " tem " + idade[cont] + " anos");
            }
            #endregion
            */
            #region Encerramento
            Console.WriteLine("\n\nPressione qualquer tecla para sair....");
            Console.ReadKey();
            Console.Clear();
            #endregion

        }
    }
}
