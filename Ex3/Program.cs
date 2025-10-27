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

            int opcao = 0, num1 = 0, num2 = 0;

            Console.WriteLine($@"
            --------MENU--------
            (1) Calcular MMC

            (2) Calcular MDC

            (3) Sair do programa
            _____________________
            ");

            opcao = int.Parse(Console.ReadLine());

            while (opcao != 3)
            {
                Console.WriteLine("Informe o valor 1 (número maior que zero):");
                num1 = int.Parse(Console.ReadLine());
                while (num1 <= 0 )
                {
                    num1 = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Informe o valor 2 (número maior que zero):");
                num2 = int.Parse(Console.ReadLine());
                while (num2 <= 0)
                {
                    num2 = int.Parse(Console.ReadLine());
                }

                switch (opcao)
                {
                    case 1:
                        int resultadoMMC = MMC(num1, num2);
                        Console.WriteLine("Mínimo múltiplo comum: " + resultadoMMC);
                        break;
                    case 2:
                        Console.WriteLine("Informe o valor 3 (número maior que zero):");
                        int num3 = int.Parse(Console.ReadLine());
                        while (num3 <= 0)
                        {
                            Console.WriteLine("Informe um número maior que 0! Valor 3:");
                            num3 = int.Parse(Console.ReadLine());
                        }
                        int resultadoMDC = MDC(num1, num2, num3);
                        Console.WriteLine("Máximo divisor comum: " + resultadoMDC);
                        break;
                    case 3:

                        break;
                    default:
                        Console.WriteLine("Opção Inválida!");
                        break;
                }
            Console.WriteLine($@"
            --------MENU--------
            (1) Calcular MMC

            (2) Calcular MDC

            (3) Sair do programa
            _____________________
            ");

            opcao = int.Parse(Console.ReadLine());
            } 
        }
        static int MMC(int valor1, int valor2)
        {
            return (valor1 * valor2) / MDC(valor1, valor2);
        }
        static int MDC(int valor1, int valor2)
        {
            int menor;

            if (valor1 < valor2)
                menor = valor1;
            else
                menor = valor2;

            int mdc = 1; 

            for (int i = 1; i <= menor; i++)
            {
                if (valor1 % i == 0 && valor2 % i == 0)
                {
                    mdc = i; 
                }
            }
            return mdc;
        }
        static int MDC(int valor1, int valor2, int valor3)
        {
            int mdcAB = MDC(valor1, valor2);   
            int mdcABC = MDC(mdcAB, valor3); 
            return mdcABC;
        }
    }
}

