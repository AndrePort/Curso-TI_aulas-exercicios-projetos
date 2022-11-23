using System;
using System.Globalization; //Usada para utilizar uma complementação(variavel)
namespace Aula01
{
    class Program
    {
        static void Main(string[] args)
        {   Console.WriteLine(" \n \n \n \n \n ");          //WriteLine: escreve palavras pulando para linha de baixo.
            Console.WriteLine("***** DADOS DIGITADOS EM TEMPO DE PROGRAMAÇÃO *******");
            Console.WriteLine("Nome..: Andre"); 
            Console.WriteLine("Idade.: 19");
            Console.WriteLine("Altura: 1.76");
            Console.WriteLine("Sexo..: M");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("\n\n");

            //Criando o mesmo texto acima, porém com VARÍAVEIS
            String nomePessoa;                              // String: Duas ou mais letras, numero e caracter especial, maior quantidade de caracteres
            Char sexoPessoa;                                // Char: somente um caracter, menos byte q a string.
            int idadePessoa;                                // Int: Apenas números, não aceita numeros com virgulas, Long int, para mais de 32k de numeros
            double alturaPessoa, multIdadePelaAlt;                            // double: Utilizado para numeros com "," (altura, medidas etc..)

            Console.WriteLine("********* DADOS DE ENTRADA **************************");
            Console.Write("Digite seu nome.........: ");    //Write: escreve tudo em uma linha
            nomePessoa = Console.ReadLine();                // le a linha de cima, espera digitar.
            Console.Write("Digite seu sexo: F, M ou O: ");
            sexoPessoa = char.Parse(Console.ReadLine());    //Parse = Análise, transforma tudo do console readline em char atraves do comando Parse
            Console.Write("Digite sua  idade.......: ");
            idadePessoa = int.Parse(Console.ReadLine());
            Console.Write("Digite sua altura...: ");
            alturaPessoa = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture); // usa um sistema internacional(padrao internacional), mudando a virgula para ponto.
            //Área de Cálculos
            //calculando a idade da pessoa * a altura dela
            multIdadePelaAlt = idadePessoa * alturaPessoa;

            Console.WriteLine("\n********** DADOS DE SAÍDA ***************************");
            Console.WriteLine("Seu nome é..: " + nomePessoa); // + junta a variavel com a escrita
            Console.WriteLine("Seu sexo é..: " + sexoPessoa);
            Console.WriteLine("Sua idade é.: " + idadePessoa);
            Console.WriteLine("Sua altura é: " + alturaPessoa.ToString("F2",CultureInfo.InvariantCulture)); //Aumenta a quantidade de zeros com base no "f"
            Console.WriteLine("A multiplicação da idade * a altura é: " + multIdadePelaAlt.ToString("F2",CultureInfo.InvariantCulture)); 
            Console.WriteLine("\n\n");

        }   
    
    }
}

