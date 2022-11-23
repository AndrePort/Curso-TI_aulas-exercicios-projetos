using System;
                                       //Ctrol + C encerra o programa
namespace Aula13_EstruturaCondicional
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Bloco de declaração de variáveis
            Console.Clear();
            int horario = 5, numero, horarioDigitado;
            string nome;
            #endregion

            #region Bloco I de Processamento de Dados
            /*********************************************
            * Verificando o Horário - CONDICIONAL SIMPLES
            *********************************************/
            //criando o título
            Console.WriteLine("************************************************");
            Console.WriteLine("*************** Usando IF SIMPLES **************");
            Console.WriteLine("************************************************");
            
            //criando a condicional
            if(horario > 5)
            {
                Console.WriteLine("Bom dia");
            }

            if(horario < 5){Console.WriteLine("Boa tarde");} //Outro modo de digitat o código

            if(horario != 5)
            {
                Console.WriteLine("Boa noite");
            }

            #endregion 

            #region Bloco II de Processamento de Dados
            /*********************************************
            * Verificando o Horário - CONDICIONAL COMPOSTA
            *********************************************/ 
            //criando o título
            Console.WriteLine("\n************************************************");
            Console.WriteLine("*************** Usando IF E ELSE ***************");
            Console.WriteLine("************************************************");

            //entrada de dados
            Console.Write("Digite seu nome........: ");
            nome = Console.ReadLine();
            Console.Write("Digite um valor inteiro: ");
            numero = int.Parse(Console.ReadLine());

            //buscando o resto da divisão
            int resto = numero %     2;

            //verificando se o valor é par
            if(resto == 0)
            {
                Console.WriteLine(nome + ", o valor " + numero + "/2 tem resto = " + resto + ". Portanto é PAR");
            }
            else
            {
            Console.WriteLine(nome + ", o valor " + numero + "/2 tem resto = " + resto + ". Portanto é IMPAR");
            }

            #endregion           

            #region Bloco III de Processamento de Dados
            /*********************************************
            * Verificando o Horário - CONDICIONAL COMPOSTA
            *********************************************/ 
            //criando o título
            Console.WriteLine("\n*******************************************************");
            Console.WriteLine("*************** Usando If, Else e Else If *************");
            Console.WriteLine("*******************************************************");
            
            //entrada de dados
            Console.Write("Digite um horário: ");
            horarioDigitado = int.Parse(Console.ReadLine());

            //nossa CONDICIONAL Principal é uma CONDICIONAL COMPOSTA
            if(horarioDigitado >= 0 && horarioDigitado <= 24)
            {   
                //começando uma nova condicional - CONDICIONAL ENCADEADA
                if(horarioDigitado < 12)
                {
                Console.WriteLine("Bom dia!");
                }
                else if(horarioDigitado < 18)
                {
                    Console.WriteLine("Boa tarde!");
                }
                else if(horarioDigitado < 24)
                {
                    Console.WriteLine("Boa noite!");
                }
                else if(horarioDigitado == 24)
                {
                    Console.WriteLine("Acabou de iniciar um novo dia!!!");
                }
            }
            else
            {
                Console.WriteLine("Por favor, digite um valor entre 0 e 24");
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
