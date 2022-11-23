using System;

namespace CONDICIONAL_WHILE_8
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Area de variavel
            //Exercício 08) O algoritmo terá que ler 1 vez o nome do usuário e um número. Após essas entradas terá que fazer o cálculo do valor digitado de 5 em 5 chegando ao valor 100 ou mais o programa deve ser encerrado.
            Console.Clear();
            int numero;
            string nome;
            #endregion

            #region Programa
            //entrada de dados
            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.Write("Digite um número: ");
            numero = int.Parse(Console.ReadLine());

            if(numero > 100)
            {
                Console.WriteLine("Você digitou " + numero + " e por ser maior que 100 não entrou no WHILE");
            }
            else
            {                
                //início do laço de repetição crescente
                while (numero <= 100)
                {
                    //entrada de dados
                    Console.WriteLine("O valor digitado de 5 em 5 é: " + numero);
                    
                    //contador do laço               
                    numero = numero + 5;
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
