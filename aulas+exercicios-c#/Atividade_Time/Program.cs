using System;

namespace Time
{
    class Program
    {
        static void Main(string[] args)
        {
            String nomeTime;
            Char   nomeGenero;
            int    nomeQuant;
            

            Console.WriteLine("\n \n ");
            Console.WriteLine("---------- ESCOLHA SEU TIME ---------");
            Console.Write("Escolha seu time........: ");
            nomeTime = Console.ReadLine();
            Console.Write("Escolha sua formação....: ");
            nomeQuant = int.Parse(Console.ReadLine());
            Console.Write("Escolha o gênero: M ou F: ");
            nomeGenero = Char.Parse(Console.ReadLine());

            Console.WriteLine("\n ");
            Console.WriteLine("------------ ESCALAÇÃO ------------- ");
            Console.WriteLine("Time....: " + nomeTime);
            Console.WriteLine("Formação: " + nomeQuant);
            Console.WriteLine("Gênero..: " + nomeGenero);
            Console.WriteLine("\n ");


        }
    }
}
