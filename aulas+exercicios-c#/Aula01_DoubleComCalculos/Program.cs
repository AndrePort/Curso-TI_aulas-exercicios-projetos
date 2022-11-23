using System;
using System.Globalization;

namespace Aula01_DoubleComCalculos
{
    class Program
    {
        static void Main(string[] args)
        {   
            /*************************************************************************************************
            * Área de declaração de VARIÁVEIS
            *************************************************************************************************/
            string nomePessoa, nomePessoa2;
            char sexoPessoa, sexoPessoa2;
            int idadePessoa, idadePessoa2;
            double alturaPessoa, alturaPessoa2, multIdadePelaAlt, mediaIdades, mediaAlturas;

            /*************************************************************************************************
            * Área de Entrada de Dados
            *************************************************************************************************/
            Console.WriteLine("***************** DADOS DE ENTRADA Pessoa 01 *****************");
            Console.Write("Digite seu nome...........: ");
            nomePessoa = Console.ReadLine();
            Console.Write("Digite seu Sexo: F, M ou O: ");
            sexoPessoa = char.Parse(Console.ReadLine());
            Console.Write("Digite sua idade..........: ");
            idadePessoa = int.Parse(Console.ReadLine());
            Console.Write("Digite sua altura.........: ");
            alturaPessoa = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            
            Console.WriteLine("***************** DADOS DE ENTRADA Pessoa 02 *****************");
            Console.Write("Digite seu nome...........: ");
            nomePessoa2 = Console.ReadLine();
            Console.Write("Digite seu Sexo: F, M ou O: ");
            sexoPessoa2 = char.Parse(Console.ReadLine());
            Console.Write("Digite sua idade..........: ");
            idadePessoa2 = int.Parse(Console.ReadLine());
            Console.Write("Digite sua altura.........: ");
            alturaPessoa2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            
            /*************************************************************************************************
            * Área de Cálculos
            *************************************************************************************************/
            //calculando a idade da pessoa * a altura dela
            multIdadePelaAlt = idadePessoa * alturaPessoa;

            //calculando a média de idade das pessoas
            mediaIdades = (idadePessoa + idadePessoa2) / 2;

            //calculando a média de altura das pessoas
            mediaAlturas = (alturaPessoa + alturaPessoa2) / 2;

            /*************************************************************************************************
            * Área de Saída de Dados
            *************************************************************************************************/
            Console.WriteLine("\n\n**************** DADOS DE SAÍDA ********************");
            Console.WriteLine("Olá " + nomePessoa + ", seu sexo é: " + sexoPessoa + ", sua idade é: " + idadePessoa + " e sua altura é: " + alturaPessoa.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Olá " + nomePessoa2 + ", seu sexo é: " + sexoPessoa2 + ", sua idade é: " + idadePessoa2 + " e sua altura é: " + alturaPessoa2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("A média das alturas é: " + mediaAlturas.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("A média das idades é.: " + mediaIdades.ToString("F2", CultureInfo.InvariantCulture)); 
            Console.WriteLine("A multiplicação da idade * a altura é: " + multIdadePelaAlt.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("\n\n");
       }
        }
    }
