using System;

namespace atividade_es2
{
    public class Calculadora
    {
        public static double Calcular(double valor1, double valor2, String operador)
        {
            double resultado;
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
                        throw new Exception("Erro: divisão por zero.");
                    }
                    break;
                default:
                    throw new Exception("Erro: Operador inválido.");
            }
            return resultado;

        }
    }
}
