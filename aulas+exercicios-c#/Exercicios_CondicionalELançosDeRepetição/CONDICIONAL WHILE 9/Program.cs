using System;
using System.Globalization;
namespace CONDICIONAL_WHILE_9
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Area de variavel
            //A loja “ Casas da Chica” quer saber a média de salário que para a seus funcionários. 
            //A loja não tem uma quantidade certa de funcionários, portanto faça um algoritmo que sempre pergunte quantos funcionários a loja tem para que a partir disso seja construído 
            //o laço para digitação dos salários.
            Console.Clear();
            double salario, acumulaSalario = 0.0, mediaSalario;
            int cont = 1, qtdFuncionarios;
            #endregion

            #region Programa
            //entrada de dados
            Console.Write("Digite quantos funcionários a loja tem: ");
            qtdFuncionarios = int.Parse(Console.ReadLine());
            
            //início do laço de repetição crescente
            while (cont <= qtdFuncionarios)
            {
                //entrada de dados
                Console.Write("Digite o salário do funcionário " + cont + "/" + qtdFuncionarios + ":");
                salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                //acumulando os salários digitados
                acumulaSalario = acumulaSalario + salario; 

                //contador do laço               
                cont++;

                Console.ReadKey();
            }
            //calculando a média do salário
            mediaSalario = acumulaSalario / qtdFuncionarios;

            //saída de dados
            Console.WriteLine("A média salarial é...: " + mediaSalario.ToString("F2", CultureInfo.InvariantCulture));   
            Console.WriteLine("O Salário Acumulado é: " + acumulaSalario.ToString("F2", CultureInfo.InvariantCulture));      
            #endregion

            #region Encerramento
            Console.WriteLine("\n\nPressione qualquer tecla para sair....");
            Console.ReadKey();
            Console.Clear();

            #endregion
        }
    }
}
