using System;

namespace IFeElse2
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
            double mult = numero1 * numero2;
            double subt = numero1 - numero2;

            //criando condicional
            Console.Clear();
            Console.WriteLine("Belezaa, agr vamos laa...");
            Console.ReadKey();
            Console.Clear();

            if(numero1 < numero2)
            {
                Console.WriteLine("Tchanamm... O primerio numero foi multiplicado pelo segundo, por tanto o valor dele agora éee..: " + mult);  
            }
            else
            {
                 Console.WriteLine("Tchanamm... O primerio numero foi subtraido pelo segundo, por tanto o valor dele agora éee..: " + subt);
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
