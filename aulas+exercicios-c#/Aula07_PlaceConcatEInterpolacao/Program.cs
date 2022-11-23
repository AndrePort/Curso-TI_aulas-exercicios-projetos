using System;
using System.Globalization;
namespace Aula07_PlaceConcatEInterpolacao
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Declaração de Variáveis
            Console.Clear();
            int idadeFuncionario;
            double salarioFuncionario;
            string nomeFuncionario;
            #endregion

            #region Área Principal
            //Entrada de Dados
            Console.Write("Digite seu nome...: ");
            nomeFuncionario = Console.ReadLine();
            Console.Write("Digite sua idade..: ");
            idadeFuncionario = int.Parse(Console.ReadLine());
            Console.Write("Digite seu salário R$: ");
            salarioFuncionario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Saída de Dados

            Console.WriteLine("\n**** Saída por PlaceHolder ****");
            Console.WriteLine("{0} tem {1} ano(s) e seu salário é R$ {2:F2}.", nomeFuncionario, idadeFuncionario, salarioFuncionario);
            Console.WriteLine("{0} tem {1} ano(s) e seu salário é R$ {2}.", nomeFuncionario, idadeFuncionario, salarioFuncionario.ToString("F3",  CultureInfo.InvariantCulture));
            

            Console.WriteLine("\n**** Saída por Interpolação ****");
            Console.WriteLine($"{nomeFuncionario} tem {idadeFuncionario} anos(s) e seu salário é R$ {salarioFuncionario.ToString("F3", CultureInfo.InvariantCulture)}");



            Console.WriteLine("\n**** Saída por Concatenação ****");
            Console.WriteLine(nomeFuncionario +  " tem " + idadeFuncionario + " anos(s) e seu salário é R$ " + salarioFuncionario.ToString("F3", CultureInfo.InvariantCulture));

            #endregion

            #region  Area de Encerramento do Programa

            Console.WriteLine("\n\nPressione qualquer tecla para sair....");
            Console.ReadKey(); 
            Console.Clear(); 
            #endregion
        }
    }
}
