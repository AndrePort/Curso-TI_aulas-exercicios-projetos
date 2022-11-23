using System;

namespace Nova_pasta
{
    class Program
    {
        static void Main(string[] args)
        {
           #region Bloco de Declaracao de Variaveis
            //limpando o terminal antes de executar
            Console.Clear();

            //bloco de variáveis
            string textoARetirar, textoAAcrescentar, substituiTextoOriginal, textOriginal, textoMaiusculo, textoMinusculo, textoSemEspaco, textoOriginalaPartirDe, textoOriginalEntre, textoOriginalSubstituido;
            int posicaoInicial, posicaoFinal;
            char retirarLetra, alterarLetra;
            #endregion

            #region Bloco de funcoes Upper, Lower, TRIM
            /**************************************************************************************************
             ******************************************** BLOCO 01 ********************************************
             *********************************** DIGITE ABC abc DEF def ***************************************
             **************************************************************************************************/
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("********************** CONVERTENDO TEXTO DIGITADO *********************************");
            Console.WriteLine("***********************************************************************************");
            Console.Write("Digite uma sequência de caracteres Maiúsculas e Minúscula: ");
            textOriginal = Console.ReadLine();

             //manipulando os valores através de FUNÇÕES (ToUpper, ToLower, Trim)
            textoMaiusculo = textOriginal.ToUpper(); //converte td que foi digitado em MAIÚSCULO
            textoMinusculo = textOriginal.ToLower(); //converte td que foi digitado em minúsculo
            textoSemEspaco = textOriginal.Trim(); //retira espaço antes e depois do texto

            //mostrando o resultado
            Console.WriteLine("\nFoi digitado: << " + textOriginal + " >> com o - ToUpper - foi transformado em: " + textoMaiusculo);
            Console.WriteLine("Foi digitado: << " + textOriginal + " >> com o - ToLower - foi transformado em: " + textoMinusculo);
            Console.WriteLine("Foi digitado: << " + textOriginal + " >> com o - Trim - foi transformado em...: " + textoSemEspaco);
            Console.WriteLine("\n\n");
            #endregion

            #region Bloco que determina o início e fim de uma frase/palavra
            Console.WriteLine("\n\n\t*** RETIRE LETRAS DO INÍCIO E DO FIM DA PALAVRA/FRASE ***");

            //bloco de entrada de dados
            Console.Write("Digite que posição deseja iniciar: ");
            posicaoInicial = int.Parse(Console.ReadLine());
            Console.Write("Digite até que posição deseja ir.: ");
            posicaoFinal = int.Parse(Console.ReadLine());

            //bloco de análise de dados
            textoOriginalaPartirDe = textOriginal.Substring(posicaoInicial);
            textoOriginalEntre = textOriginal.Substring(posicaoInicial, posicaoFinal);

            //bloco de impressão de dados
            Console.WriteLine("\nO Texto original é: " + textOriginal + " e irá inicial em...........: " + textoOriginalaPartirDe);
            Console.WriteLine("O Texto original é: " + textOriginal + " e irá inicial e terminar em: " + textoOriginalEntre);
            #endregion

            #region Bloco de substituição de letras
            Console.WriteLine("\n\n\t*** SUBSTITUA LETRAS DA FRASE/PALAVRAS ***");

            //bloco de entrada de dados
            Console.Write("Digite a letra que deseja retirar: ");
            retirarLetra = char.Parse(Console.ReadLine());
            Console.Write("Digite a letra que deseja incluir: ");
            alterarLetra = char.Parse(Console.ReadLine());

            //bloco de análise de dados
            textoOriginalSubstituido = textOriginal.Replace(retirarLetra, alterarLetra);

            //bloco de impressão de dados
            Console.WriteLine("O texto original é...: " + textOriginal);
            Console.WriteLine("O texto substituido é: " + textoOriginalSubstituido);

            #endregion

            #region Substituição de String
            Console.WriteLine("\n\n\t*** Substituindo Strings ***");

            //bloco de entrada de dados
            Console.Write("Digite a palavra que quer substituir do textoOriginal.......................: ");
            textoARetirar = Console.ReadLine();

            Console.Write("Digite o texto que quer colocar no trecho a ser substituido do textoOriginal: ");
            textoAAcrescentar = Console.ReadLine();

            //bloco de análise de dados
            substituiTextoOriginal = textOriginal.Replace(textoARetirar, textoAAcrescentar);

            //bloco de saída de dados
            Console.WriteLine("O textoOriginal é: " + textOriginal);
            Console.WriteLine("O substituido é..: " + substituiTextoOriginal);

            #endregion

            #region Teste de String vazia
            //bloco de declaração de var
            string nuloOuVazio;

            //bloco de entrada de dados
            Console.WriteLine("\n\n\t*** Testando String Vazia*** ");
            Console.Write("Digite um texto ou simplestemente dê ENTER: ");
            nuloOuVazio = Console.ReadLine();

            //bloco de análise de dados
            bool verificaNuloOuVazio = string.IsNullOrEmpty(nuloOuVazio);

            //bloco de saída de dados
            Console.WriteLine("O texto digitado foi...........: " + nuloOuVazio);
            Console.WriteLine("Sendo assim, o texto está vazio? " + verificaNuloOuVazio);

            #endregion

            #region Achando a posição dentro do texto
            Console.WriteLine("\n\n\t*** Ache a posição ***");

            //bloco de variáveis
            string achaTexto;
            int primeiraPosicao, ultimaPosicao;

            //bloco de entrada de dados
            Console.WriteLine("Digite o texto que queira achar na variável textOriginal: ");
            achaTexto = Console.ReadLine();

            //bloco de análise de dados
            //achando a primeira posição da palavra digitada
            primeiraPosicao  = textOriginal.IndexOf(achaTexto);
            //achando a última posição da palavra digitada
            ultimaPosicao  = textOriginal.LastIndexOf(achaTexto);

            //bloco de saída de dados
            Console.WriteLine("A PRIMEIRA posição encontrada foi: " + primeiraPosicao);
            Console.WriteLine("A ÚLTIMA posição encontrada foi..: " + ultimaPosicao);

            #endregion

            #region Bloco de encerramento e limpeza do console
            //pedindo para o usuário encerrar o programa
            Console.Write("Clique em qualquer tecla para encerrar");
            Console.ReadKey();

            //limpando o console
            Console.Clear();
            #endregion
        }
    }
}
