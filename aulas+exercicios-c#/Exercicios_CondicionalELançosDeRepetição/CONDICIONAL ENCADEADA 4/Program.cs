using System;

namespace CONDICIONAL_ENCADEADA_4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Declaração das variaveis
            Console.Clear();
            int numero1, numero2;
            string nome;
            #endregion

            #region Bloco de processamento
            //entrada de dados
            Console.WriteLine("*_*-*_*_*-*_*_*-*_*_*-*_*_*-*_*_*-*_*_*-*_*_*-*_*_*-*_*_*-*_*");
            Console.WriteLine("*_*-*_*_*-*_*_*-*_*_*-*_ GAME MAGICK *_*-*_*_*-*_*_*-*_*_*-*_");
            Console.WriteLine("*_*-*_*_*-*_*_*-*_*_*-*_*_*-*_*_*-*_*_*-*_*_*-*_*_*-*_*_*-*_*");

            Console.Write("\nDigite seu nome: ");
            nome = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Olá " + nome + " vamos brincar?");
            Console.Write("Digite um numero: ");
            numero1 = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Agora poderia digitar mais um numero qualquer?");
            Console.Write("numero2: ");
            numero2 = int.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Belezaa, agr vamos laa...");
            Console.ReadKey();
            Console.Clear();
            #endregion

            #region Bloco de criação de condicional encadeada
            //criando condicional / saida de dados
            if(numero1 > numero2)
            {
            Console.WriteLine("A é maior que B");
            }
            else if(numero2 > numero1)
            {
            Console.WriteLine("B é maior que A");
            }
            else
            {
            Console.WriteLine("Os números são iguais");
            }
            
            #endregion  
            
            #region Area de Encerramento do Programa
            Console.WriteLine("\n\n\n\n\n\n\n\nPressione qualquer tecla para sair....");
            Console.ReadKey();
            Console.Clear();
            #endregion
        }
    }
}
