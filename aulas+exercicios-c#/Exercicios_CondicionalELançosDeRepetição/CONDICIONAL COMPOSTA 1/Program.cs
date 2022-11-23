using System;

namespace IFeElse1
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

            //Area de calculo
            double div = numero1 / numero2;
            double soma = numero1 + numero2;

            //criando condicional / saida de dados
            Console.Clear();
            Console.WriteLine("Belezaa, agr vamos laa...");
            Console.ReadKey();
            Console.Clear();

            if(numero1 > numero2)
            {
                Console.WriteLine("Tchanamm... O primerio numero foi dividido pelo segundo: " + div);  
            }
            else
            {
                 Console.WriteLine("Tchanamm... O primerio numero foi somado com o segundo, por tanto o valor dele agora éee..: " + soma);
            }
            #endregion 

            #region Area de Encerramento do Programa
            Console.WriteLine("\n\nPressione qualquer tecla para sair....");
            Console.ReadKey();
            Console.Clear();
            #endregion

        }
    }
}
