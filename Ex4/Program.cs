using System;

namespace Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*04. Escreva um método que receba como parâmetros 3 números inteiros e uma letra (char). Se a letra for ‘A’,
            o método deve calcular e escrever a média aritmética dos valores recebidos como parâmetros. Se a letra for
            ‘P’, o método deve imprimir a média ponderada, usando os seguintes pesos: 5, 3 e 2. Para outras letras, o
            procedimento deve exibir uma mensagem indicando que não é possível fazer nenhum cálculo.*/

            int num1, num2, num3;
            char opcao;

            Console.WriteLine("Informe o número 1:");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o número 1:");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o número 1:");
            num3 = int.Parse(Console.ReadLine());

            Console.WriteLine(@"Informe a opção desejada:
            --------MENU--------
            (P) Média Ponderada

            (A) Média Aritmética
            _____________________
            ");
            opcao = char.Parse(Console.ReadLine().ToUpper());

            switch (opcao)
            {
                case 'P':
                    double calcPonderada = Ponderada(num1, num2, num3);
                    Console.WriteLine("Média Ponderada = " + calcPonderada);
                    break;
                case 'A':
                    double calcArtmetica = Aritmetica(num1, num2, num3);
                    Console.WriteLine("Média Ponderada = " + calcArtmetica);
                    break;
                case 'E':

                    break;
                default:
                    Console.WriteLine("Não é possível fazer nenhum cálculo!");
                    break;
            }
        }
        static double Ponderada (int valor1, int valor2, int valor3)
        {
            return ((valor1 * 5) + (valor2 * 3) + (valor3 * 2)) / (double)(5 + 3 + 2);
        }
        static double Aritmetica (int valor1, int valor2, int valor3)
        {
            return (valor1 + valor2 + valor3) / 3.0;
        }
    }
}
