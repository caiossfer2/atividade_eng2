using System;

namespace atividade_es2
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor1, valor2, resultado;
            string operador;

            Console.WriteLine("Digite o primeiro valor:");
            valor1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o operador (+, -, *, /):");
            operador = Console.ReadLine();

            Console.WriteLine("Digite o segundo valor:");
            valor2 = double.Parse(Console.ReadLine());

            switch (operador)
            {
                case "+":
                    resultado = valor1 + valor2;
                    break;
                case "-":
                    resultado = valor1 - valor2;
                    break;
                case "*":
                    resultado = valor1 * valor2;
                    break;
                case "/":
                    if (valor2 != 0)
                        resultado = valor1 / valor2;
                    else
                    {
                        Console.WriteLine("Erro: divisão por zero.");
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("Operador inválido.");
                    return;
            }

            Console.WriteLine("Resultado: " + resultado);
        }
    }
}