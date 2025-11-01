using System;
using System.ComponentModel;

namespace Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*05. Implemente um método que receba um vetor de char como parâmetro e retorne o número de vogais que constam no vetor.*/

            int num = 0;

            Console.WriteLine("Quantas letras deseja informar?");
            num = int.Parse(Console.ReadLine());

            char[] letras = new char[num];

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"Letra {i + 1}:");
                letras[i] = char.Parse(Console.ReadLine().ToLower());
            }
        }
        static char [] Vogais ()
        {
            char [] vogais = { 'a', 'e', 'i', 'o','u'};
            return vogais;
        }
    }
}
