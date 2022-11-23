using System;

namespace Aula15_EstruturaFOR
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Área de Variáveis
            Console.Clear();
            int cont1, qtdFuncionarios = 0, acumulaIdade = 0, idade = 0, media = 0;
            #endregion 

            #region Main do Programa usando FOR e comparando com a WHILE
            //tipo 1 de laço FOR (iniciando varíavel nele mesmo)
            //for(<INICIALIZADOR>;<COMPARADOR>;<ACUMULADOR>) //ja no FOR fica tudo junto, usa quando tem certeza que deseja utilizar tal laço, ja o WHILE é quando vc quer dar mais opçoes ao utilizador(interferencia do usuario).
            for(cont1 = 1;cont1 <= 10;cont1++)
            {
                Console.WriteLine("\n\nEstá é a passagem [" + cont1 + "] no laço FOR");
            }
            //Para comparar o laço de cima, vamos fazer o mesmo no WHILE
            //incializo o cont antes do laço
            cont1 = 1;
            //faço a comparação
            //while(<comparador>)
        
            while(cont1 <= 10)
            {

                Console.WriteLine("Estou fora do FOR e o cont1 tem  o valor de: [" + cont1 + "]\n\n");

                
                //no final coloco o acumulador ou o comparador
                //cont++; Ou opcao = "s";
                cont1++;
            }
            /*Código identido ao anterior. Estamos somente
             comentando a linha abaixo para entender ;
             quando deve-se usar FOR e quando deve-se ;
             usar WHILE */
;
            #endregion

            #region Criando um Programa com o For
            //entrada de dados
            Console.Write("Digite quantos funcionarios você têm: ");
            qtdFuncionarios = int.Parse(Console.ReadLine());

            //criando o laço usando o for
            for(int cont2 = 1; cont2 <= qtdFuncionarios; cont2++)
            {
                Console.Write("Digite a idade do funcionario: " + cont2);
                idade = int.Parse(Console.ReadLine());

                //acumulando as idades 
                acumulaIdade = acumulaIdade + idade;
            }

            //calculando média
            media = acumulaIdade / qtdFuncionarios;

            //imprimindo o resultado
            Console.WriteLine("Você tem " + qtdFuncionarios + " funcionarios e a média de idade é: " + media);

            #endregion
            #region Encerramento
            Console.WriteLine("\n\nPressione qualquer tecla para sair....");
            Console.ReadKey();
            Console.Clear();
            #endregion
        }
    }
}