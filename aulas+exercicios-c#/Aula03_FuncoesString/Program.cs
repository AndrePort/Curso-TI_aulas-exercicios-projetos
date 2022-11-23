using System;

namespace Aula03_FuncoesString
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Bloco de Declaração  de Variáveis
            //Limpando terminal antes de começar
            Console.Clear();

            //Bloco de varíaveis
            string textoAretirar, textoAacrescentar, SubstituiTextoOriginal, textoOriginal, textoMaiusculo, textoMinusculo, textoSemEspaço, textoOriginalaPartirDe, textoOriginalEntre, textoOriginalSubstituido;
            int posicaoInicial, posicaoFinal;
            char retiraLetra, alterarLetra;
            #endregion  

            #region Bloco de fuções Upper, Lower, TRIM
            /**************************************************************************************************
            ******************************************** BLOCO 01 ********************************************
            *********************************** DIGITE ABC abc DEF def ***************************************
            **************************************************************************************************/
            Console.WriteLine("************************************************************************************");
            Console.WriteLine("************************** CONVERTENDO TEXTO DIGITADO *******************************");
            Console.WriteLine("************************************************************************************");
            Console.Write("Digite uma sequência de caracteres Maíusculas e Minúsculas: ");
            textoOriginal = Console.ReadLine(); 

            //Manipulando os valores através de FUNÇÕES (ToUpper, ToLower, Trim)
            textoMaiusculo = textoOriginal.ToUpper(); //converte tudo que foi digitado em MAIÚSCULO
            textoMinusculo = textoOriginal.ToLower(); //converte tudo que foi digitado em minúsculo
            textoSemEspaço = textoOriginal.Trim();    // retirar espaço antes e depois do texto

            //Mostrando o resultado
            Console.WriteLine("\nFoi digitado: << " + textoOriginal + " >> com o - ToUpper - foi transformado em: " + textoMaiusculo);
            Console.WriteLine("Foi digitado: << " + textoOriginal + " >> com o - ToLower - foi transformado em: " + textoMinusculo);
            Console.WriteLine("Foi digitado: << " + textoOriginal + " >> com o - Trim - foi transformado em...: " + textoSemEspaço);
            Console.WriteLine("\n\n");
            #endregion

            #region Bloco que determina o incio e fim de uma frase/palavra
            Console.WriteLine("\n\n\t*** RETIRE LETRAS DO INICIO E DO FIM DA PALAVRA/FRASE *** ");

            //Bloco de entrada de dados
            Console.WriteLine("Digite que posição deseja iniciar: ");
            posicaoInicial = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite  até que posição deseja ir: ");
            posicaoFinal = int.Parse(Console.ReadLine());

            //Bloco de análise  de dados
            textoOriginalaPartirDe = textoOriginal.Substring(posicaoInicial); // Determina onde começa e onde termina
            textoOriginalEntre =  textoOriginal.Substring(posicaoInicial, posicaoFinal); // COmeça o texto de acordo com o poscição selecionada.

            //Bloco de impressão de dados
            Console.WriteLine("O texto original é: " + textoOriginal + " e irá iniciar em ...........: " + textoOriginalaPartirDe);
            Console.WriteLine("O texto original é: " + textoOriginal + " e irá iniciar e terminar em : " + textoOriginalEntre);
           
            #endregion

            #region Bloco de substituição de letras
            Console.WriteLine("\n\n\t *** SUBSTITUA LETRAS DA FRASE/PALAVRAS ***");

            //Bloco  de entrada de dados
            Console.WriteLine("Digite a letra que deseja substituir: "); 
            retiraLetra = char.Parse(Console.ReadLine());
            Console.WriteLine("Digite a letra que deseja incluir: ");
            alterarLetra = char.Parse(Console.ReadLine());

            //Bloco de análise de dados
            textoOriginalSubstituido = textoOriginal.Replace(retiraLetra, alterarLetra); //Substitui as letras escolhidas

            //Bloco de impressão de dados
            Console.WriteLine("O texto original é...:" + textoOriginal);
            Console.WriteLine("O texto substituido é: " + textoOriginalSubstituido);
            #endregion

            #region Substituição de String 
            Console.WriteLine("\n\n\t *** Substituindo  Strings ***");
            
            //bloco de entrada de dados
            Console.WriteLine("Digite a palavra que quer substituir do textoOriginal: ");
            textoAretirar = Console.ReadLine();

            Console.Write("Digite o texto que quer colocar no textoOriginal.........: ");
            textoAacrescentar = Console.ReadLine();

            //bloco de Análise de dados
            SubstituiTextoOriginal = textoOriginal.Replace(textoAretirar, textoAacrescentar); //REPLACE: Ele procura a palavra selecionada(pelo "textoAretirar") no texto, e em seguida substitui por outro palavra que foi escolhida(pelo "textoAacrescentar")

            //bloco de saida de dados
            Console.WriteLine("O textoOriginal é:" + textoOriginal);
            Console.WriteLine("O substituido é..:" + SubstituiTextoOriginal);

            #endregion

            #region Teste de String  vazia
            //bloco de declaração de var
            string nuloOuVazio;

            //bloco de entrada de dados
            Console.WriteLine("\n\n\t *** Testando String Vazia*** ");
            Console.Write("Digite um texto ou simplesmente dê um ENTER: ");
            nuloOuVazio = Console.ReadLine();

            //bloco de análise de dados
            bool verificaNuloOuVazio = string.IsNullOrEmpty(nuloOuVazio); // Só aceita TRUE ou FALSE(Ligado/Desligado)
            
            //bloco de saida de dados
            Console.WriteLine("O texto digitado foi...........: " +nuloOuVazio);
            Console.WriteLine("Sendo assim, o texto está vazio? " + verificaNuloOuVazio);

            #endregion

            #region Achando a posição dentro do texto
            Console.WriteLine("\n\n\t *** Ache a posição ***");

            //bloco de variáveis
            string AchaTexto;
            int primeiraPosicao, ultimaPosicao;

            //bloco de entrada de dados 
            Console.WriteLine("Digite o texto que queira achar na variável texotoOriginal: ");
            AchaTexto = Console.ReadLine();

            //bloco de análise de dados
            //achando a primeira posição  da palavra digitada
            primeiraPosicao = textoOriginal.IndexOf(AchaTexto); // acha a primeira referência
            //achando a última posição da palavra digitada
            ultimaPosicao = textoOriginal.LastIndexOf(AchaTexto); // acha a última referência

            //bloco de saida de dados
            Console.WriteLine("A PRIMEIRA posição encontrada foi: " + primeiraPosicao);
            Console.WriteLine("A ÚLTIMA posição encontrada foi..: " + ultimaPosicao);
            #endregion

            #region Bloco de encerramento e limpeza do programa 
            //pedindo para o usuario encerra o programa
            Console.Write("Clique em qualquer tecla para encerrar");
            Console.ReadKey();

            //Limpando programa
            Console.Clear();
            #endregion 

        }
    }
}