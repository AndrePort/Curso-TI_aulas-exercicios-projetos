using System;
using System.Globalization;

namespace Aula02_Inferencia
{
    class Program
    {
        static void Main(string[] args)
        {   

            /************************************************************
            * Declarando Varíaveis para trabalhar baseado em INFERÊNCIA
            *************************************************************/
            var numero =10;       //compilador transforma em int
            var resultado =20.0;  //compilador transforma em double
            var nome = "Maria";   //compilador transforma em string
            var sexo = "F";       //compilador transforma em char

            /************************************************************
            * Imprimindo o resultado
            ************************************************************/
            //Limpando a tela antes de iniciar a impressão de dados
            Console.Clear(); 

            //Imprimindo as vars   
            Console.WriteLine("O valor que está dentro da variável numero é...: " + numero);
            Console.WriteLine("O valor que está dentro da variável resultado é: " + resultado.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("O valor que está dentro da variável nome é.....: " + nome);
            Console.WriteLine("O valor que está dentro da variável sexo é.....: " + sexo);

             /************************************************************
            * Problemas ao trabalhar com  infêrencia
            * Usar variável por inferência precisa ser muito bem pensado e estudado pelo programador.
            * Pois, é muito facil cometer falhas e o compilador apontar diversos erros.
            ************************************************************/
            /*
            //apontar uma variável em outra que não é do mesmo tipo
            numero = nome;

            Console.WriteLine("A quantidade de usuários é: " + numero);
            */

            //comando que pausa a tela quando executamos em modo TERMINAL
            Console.WriteLine("\n\n*** Pressione qualquer tecla para encerrar o programa ***");
            Console.ReadKey();

            //Limpa o terminal antes de encerrar o programa
            Console.Clear();

        }
    }
}
