using System;

namespace Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*. Crie os seguintes métodos:
             
                ● Mmc: recebe por parâmetro dois números inteiros e retorna o mínimo múltiplo comum destes números.
                Obs: O mínimo múltiplo comum (MMC) corresponde ao menor número inteiro positivo, diferente 
                de zero, que é múltiplo ao mesmo tempo de dois ou mais números.

                ● Mdc: recebe por parâmetro três números inteiros e retorna o máximo divisor comum destes números.
                Obs: O máximo divisor comum (MDC) entre dois ou mais números naturais é o maior de seus 
                divisores.

                No método Main apresente o seguinte menu de opções para o usuário:

                (1) Calcular MMC
                (2) Calcular MDC
                (3) Sair do programa*/

            Console.WriteLine($@"
            --------MENU--------
            (1) Calcular MMC

            (2) Calcular MDC

            (3) Sair do programa
            _____________________
            ");

            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Valor 1:");
                    int mmc1 = int.Parse(Console.ReadLine());
                    while (mmc1 < 0)
                    {
                        Console.WriteLine("Informe um número maior que 0! Valor 1:");
                        mmc1 = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("Valor 2:");
                    int mmc2 = int.Parse(Console.ReadLine());
                    while (mmc2 < 0)
                    {
                        Console.WriteLine("Informe um número maior que 0! Valor 2:");
                        mmc2 = int.Parse(Console.ReadLine());
                    }

                    int resultadoMMC = MMC(mmc1, mmc2);
                    Console.WriteLine("Mínimo múltiplo comum: " + resultadoMMC);
                    break;
                case 2:
                    Console.WriteLine("Valor 1:");
                    int mdc1 = int.Parse(Console.ReadLine());
                    while (mdc1 < 0)
                    {
                        Console.WriteLine("Informe um número maior que 0! Valor 1:");
                        mdc1 = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("Valor 2:");
                    int mdc2 = int.Parse(Console.ReadLine());
                    while (mdc2 < 0)
                    {
                        Console.WriteLine("Informe um número maior que 0! Valor 2:");
                        mdc2 = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("Valor 3:");
                    int mdc3 = int.Parse(Console.ReadLine());
                    while (mdc3 < 0)
                    {
                        Console.WriteLine("Informe um número maior que 0! Valor 3:");
                        mdc3 = int.Parse(Console.ReadLine());
                    }

                    break;
                case 3:

                    break;
                default:
                    Console.WriteLine("Opção Inválida!");
                    break;
            }
        }
        static int MMC(int valor1, int valor2)
        {
            int maiorValor = 0;

            if (valor1 < valor2)
            {
                maiorValor = valor1;
            }
            else if (valor2 < valor1)
            {
                maiorValor = valor2;
            }

            for (int i = 2; i < maiorValor; i++)
            {
                //menor valor
                if (valor1 % i == 0 && valor2 % i == 0)
                {
                    return i;
                }
            }
            return 1;
        }
    }
}
