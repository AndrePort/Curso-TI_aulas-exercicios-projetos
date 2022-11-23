using System;

namespace Aula04_TestandoVariáveis
{
    class Program
    {
        #region Main
        static void Main(string[] args)
        {
            #region Bloco de Variáveis
            sbyte valorSbytePositivo = 127, valorSbyteNegativo = -128;
            byte valorByte1 = 0, valorByte2 = 255;
            short valorShortPositivo = 32767, valorShortNegativo = -32768;
            ushort valorUshortInicial = 0, valorUshortFinal = 65535;
            int valorIntPositivo = 2147483647, valorIntNegativo = -2147483647;
            uint valorUintInicial = 0, valorUintFinal = 4294967295;
            long valorLongPositivo = 9223372036854775807, valorLongNegativo = -9223372036854775808;
            ulong valorUlongInicial = 0, valorUlongFinal = 18446744073709551615;
            char opçao = '1', sexo = 'M';
            string nomeRua = "Rua: 13 de amio, n° 100.";
            bool seVerdadeiro = true, seFalse = false;
            object nome = "Lucas", altura4 = 1.77, opcao2 = true;
            float altura = 1.77f;
            double altura2 = 1.77;
            decimal altura3 = 1.77m;
             
            #endregion
            #region Programa
            //limpando a tela
            Console.Clear();

            //testando variáveis
            Console.WriteLine("\t\n*** VARIÁVEL SBYTE ACEITA DE -128 A 127 - GASTANDO 1 BYTE DE MEMÓRIA ***");
            Console.WriteLine("O valorSbytePositivo CHEGA a: " + valorSbytePositivo);
            Console.WriteLine("O valorSbyteNegativo CHEGA a: " + valorSbyteNegativo);

            Console.WriteLine("\t\n*** VARIÁVEL BYTE ACEITA DE 0 A 255 - GASTANDO 1 BYTES DE MEMÓRIA ***");
            Console.WriteLine("O valorByte1 INICIA EM......: " + valorByte1);
            Console.WriteLine("O valorByte2 TERMINA EM.....: " + valorByte2);

            Console.WriteLine("\t\n*** VARIÁVEL SHORT ACEITA DE -32768 A 32767 - GASTANDO 2 BYTES DE MEMÓRIA ***");
            Console.WriteLine("O valorShortPositivo CHEGA a: " + valorShortPositivo);
            Console.WriteLine("O valorShortNegativo CHEGA a: " + valorShortNegativo);

            Console.WriteLine("\t\n*** VARIÁVEL USHORT ACEITA DE 0 A 65535 - GASTANDO 2 BYTES DE MEMÓRIA ***");
            Console.WriteLine("O valorUshortInicial CHEGA a: " + valorUshortInicial);
            Console.WriteLine("O valorUshortFinal CHEGA a..: " + valorUshortFinal);

            Console.WriteLine("\t\n*** VARIÁVEL INT ACEITA DE -2³¹ A 2³¹ -1 - GASTANDO 4 BYTES DE MEMÓRIA ***");
            Console.WriteLine("O valorIntPositivo CHEGA a..: " + valorIntPositivo);
            Console.WriteLine("O valorIntNegativo CHEGA a..: " + valorIntNegativo);

            Console.WriteLine("\t\n*** VARIÁVEL UINT ACEITA DE 0 A 4294967295 - GASTANDO 4 BYTES DE MEMÓRIA ***");
            Console.WriteLine("O valorUintInicial CHEGA a..: " + valorUintInicial);
            Console.WriteLine("O valorUintFinal CHEGA a....: " + valorUintFinal);

            Console.WriteLine("\t\n*** VARIÁVEL LONG ACEITA DE -9223372036854775808 A 9223372036854775808 - GASTANDO 8 BYTES DE MEMÓRIA ***");
            Console.WriteLine("O valorLongPositivo CHEGA ..: " + valorLongPositivo);
            Console.WriteLine("O valorLongNegativo CHEGA a.: " + valorLongNegativo);

            Console.WriteLine("\t\n*** VARIÁVEL ULONG ACEITA DE 0 A 18446744073709551615 - GASTANDO 8 BYTES DE MEMÓRIA ***");
            Console.WriteLine("O valorUlongInicial CHEGA ..: " + valorUlongInicial);
            Console.WriteLine("O valorUlongFinal CHEGA a...: " + valorUlongFinal);

            Console.WriteLine("\t\n*** VARIÁVEL CHAR ACEITA UM CARACTER - GASTANDO 2 BYTES DE MEMÓRIA ***");
            Console.WriteLine("A opção escolhida foi.......: " + opçao);
            Console.WriteLine("O sexo escolhido foi........: " + sexo); 

            Console.WriteLine("\t\n*** VARIÁVEL STRING ACEITA NÚMERO, CARACTER ESPECIAL E OUTROS - GASTANDO 4 BYTES OU MAIS DE MEMÓRIA ***");
            Console.WriteLine("O nome da rua é.............: " + nomeRua);

            Console.WriteLine("\t\n*** VARIÁVEL BOOL ACEITA TRUE OU FALSE - GASTANDO 1/2 BYTES DE MEMÓRIA ***");
            Console.WriteLine("O nome é....................: " + nome);
            Console.WriteLine("A altura é..................: " + altura);
            Console.WriteLine("A opção é...................: " + opcao2);

            Console.WriteLine("\t\n*** VARIÁVEL OBJECT ACEITA NÚMERO, CARACTER ESPECIAL E OUTROS - GASTANDO 1/2 BYTES DE MEMÓRIA ***");
            Console.WriteLine("A primeira escolha foi......: " + seVerdadeiro);
            Console.WriteLine("A segunda escolha foi.......: " + seFalse); 


            Console.WriteLine("\t\n*** VARIÁVEL FLOAT ACEITA VALORES COM VÍRGULA - COM PRECISÃO DE 7 DIGITOS - GASTANDO 4 BYTES DE MEMÓRIA ***");
            Console.WriteLine("Sua altura é................: " + altura);

            Console.WriteLine("\t\n*** VARIÁVEL DOUBLE ACEITA VALORES COM VÍRGULA - COM PRECISÃO DE 15 A 16 DIGITOS - GASTANDO 8 BYTES DE MEMÓRIA ***");
            Console.WriteLine("Sua altura é................: " + altura2);

            Console.WriteLine("\t\n*** VARIÁVEL DECIMAL ACEITA VALORES COM VÍRGULA - COM PRECISÃO DE 28 A 29 DIGITOS - GASTANDO 16 BYTES DE MEMÓRIA ***");
            Console.WriteLine("Sua altura é................: " + altura3);
        

            #endregion

            #region Pausando a tela
            //passando a tela
            Console.WriteLine("\n\n Pressione qualquer tecla para encerrar...");
            Console.ReadKey();

            //limpando a tela ao encerrar o programa
            Console.Clear();
            #endregion
            
    
    #endregion}
        }
    }
}