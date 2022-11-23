using System;

namespace Aula05_MinEMaxDasVariaveis
{
    class Program
    {
        static void Main(string[] args)
        { 
            #region Bloco de VAR
            sbyte valorMinimoSbyte = sbyte.MinValue;
            sbyte valorMaximoSbyte = sbyte.MaxValue;
            byte valorMinimobyte = byte.MinValue;
            byte valorMaximobyte = byte.MaxValue;
            short valorMinimoshort = short.MinValue;
            short valorMaximoshort = short.MaxValue;
            ushort valorMinimoUshort = ushort.MinValue;
            ushort valorMaximoUshort = ushort.MaxValue;
            int valorMinimoInt = int.MinValue;
            int valorMaximoInt = int.MaxValue;
            uint valorMinimoUint = uint.MinValue;
            uint valorMaximoUint = uint.MaxValue;
            long valorMinimoLong = long.MinValue;
            long valorMaximoLong = long.MaxValue;
            ulong valorMinimoUlong = ulong.MinValue;
            ulong valorMaximoUlong = ulong.MaxValue;
            float valorMinimoFloat = float.MinValue;
            float valorMaximoFloat = float.MaxValue;
            double valorMinimoDouble = double.MinValue;
            double valorMaximoDouble = double.MaxValue;
            decimal valorMinimoDecimal = decimal.MinValue;
            decimal valorMaximoDecimal = decimal.MaxValue;
            

            #endregion
        
            #region Principal 
            Console.Clear();
            Console.WriteLine("\t*** IMPRIMINDO OS MÁXIMOS E MÌNIMOS DAS VARIÁVEIS ***");
            Console.WriteLine("Minimo SBYTE: " + valorMinimoSbyte);
            Console.WriteLine("Máximo SBYTE..: " + valorMaximoSbyte);
            Console.WriteLine("Minimo BYTE...: " + valorMinimobyte);
            Console.WriteLine("Máximo BYTE...: " + valorMaximobyte);
            Console.WriteLine("Minimo SHORT..: " + valorMinimoshort);
            Console.WriteLine("Máximo SHORT..: " + valorMaximoshort);
            Console.WriteLine("Minimo USHORT.: " + valorMinimoUshort);
            Console.WriteLine("Máximo USHORT.: " + valorMaximoUshort);
            Console.WriteLine("Minimo INT....: " + valorMinimoInt);
            Console.WriteLine("Máximo INT....: " + valorMaximoInt);
            Console.WriteLine("Minimo UINT...: " + valorMinimoUint);
            Console.WriteLine("Máximo UINT...: " + valorMaximoUint);
            Console.WriteLine("Minimo LONG...: " + valorMinimoLong);
            Console.WriteLine("Máximo LONG...: " + valorMaximoLong);
            Console.WriteLine("Minimo ULONG..: " + valorMinimoUlong);
            Console.WriteLine("Máximo ULONG..: " + valorMaximoUlong);
            Console.WriteLine("Minimo FLOAT..: " + valorMinimoFloat);
            Console.WriteLine("Máximo FLOAT..: " + valorMaximoFloat);
            Console.WriteLine("Minimo DOUBLE.: " + valorMinimoDouble);
            Console.WriteLine("Máximo DOUBLE.: " + valorMaximoDouble);
            Console.WriteLine("Minimo DECIMAL: " + valorMinimoDecimal);
            Console.WriteLine("Máximo DECIMAL: " + valorMaximoDecimal);
            #endregion 

            #region Pausando a tela

            //Pausando a tela
            Console.Write("\n\nPressione qualquer tecla para encerrar......");
            Console.ReadKey();

            #endregion

            #region Limpando o Console

            //Limpando a tela ao encerrar o programa
            Console.Clear();

            #endregion
 





        }
    }
}
