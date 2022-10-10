using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.Write("Selecione a operação:\n 1 - Soma\n 2 - Subtração\n 3 - Divisão\n 4 - Multiplicação\n 5 - Sair\n Selecione a operação: ");
            byte selectOption = byte.Parse(Console.ReadLine()!);

            switch (selectOption)
            {
                case 1: Sum(); break;
                case 2: Subtraction(); break;
                case 3: Division(); break;
                case 4: Multiplication(); break;
                case 5: Console.WriteLine("Calculadora encerrada!"); break;
                default: Menu(); break;
            }
        }

        static void Sum()
        {
            Console.Clear();
            Console.WriteLine("Operação selecionada SOMA");

            Console.Write("Primeiro valor: ");
            double v1 = double.Parse(Console.ReadLine()!);

            Console.Write("Segundo valor: ");
            double v2 = double.Parse(Console.ReadLine()!);

            double result = v1 + v2;

            Console.WriteLine($"Resultado da Soma {result}");
            RestartCalculator();
        }

        static void Subtraction()
        {
            Console.Clear();
            Console.WriteLine("Operação selecionada SUBTRAÇÃO");

            Console.Write("Primeiro valor: ");
            double v1 = double.Parse(Console.ReadLine()!);

            Console.Write("Segundo valor: ");
            double v2 = double.Parse(Console.ReadLine()!);

            double result = v1 - v2;

            Console.WriteLine($"Resultado da Subtração {result}");
            RestartCalculator();
        }

        static void Division()
        {
            Console.Clear();
            Console.WriteLine("Operação selecionada DIVISÃO");

            Console.Write("Primeiro valor: ");
            double v1 = double.Parse(Console.ReadLine()!);

            Console.Write("Segundo valor: ");
            double v2 = double.Parse(Console.ReadLine()!);

            double result = v1 / v2;

            Console.WriteLine($"Resultado da Divisão {result}");
            RestartCalculator();
        }

        static void Multiplication()
        {
            Console.Clear();
            Console.WriteLine("Operação selecionada MULTIPLICAÇÃO");

            Console.Write("Primeiro valor: ");
            double v1 = double.Parse(Console.ReadLine()!);

            Console.Write("Segundo valor: ");
            double v2 = double.Parse(Console.ReadLine()!);

            double result = v1 * v2;

            Console.WriteLine($"Resultado da Multiplicação {result}");
            RestartCalculator();
        }

        static void RestartCalculator()
        {
            Console.WriteLine("Pressione qualquer tecla para voltar para o menu.");
            Console.ReadKey();
            Menu();
        }
    }
}
