namespace CalculatorTests;

using atividade_es2;
using Xunit;
 public class CalculadoraTeste
    {
        [Fact]
        public void TesteSoma()
        {
            // Arrange
            double valor1 = 10;
            double valor2 = 5;
            string operador = "+";
            double resultadoEsperado = 15;

            // Act
            double resultado = Calculadora.Calcular(valor1, valor2, operador);

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Fact]
        public void TesteSubtracao()
        {
            // Arrange
            double valor1 = 10;
            double valor2 = 5;
            string operador = "-";
            double resultadoEsperado = 5;

            // Act
            double resultado = Calculadora.Calcular(valor1, valor2, operador);

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Fact]
        public void TesteMultiplicacao()
        {
            // Arrange
            double valor1 = 10;
            double valor2 = 5;
            string operador = "*";
            double resultadoEsperado = 50;

            // Act
            double resultado = Calculadora.Calcular(valor1, valor2, operador);

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Fact]
        public void TesteDivisao()
        {
            // Arrange
            double valor1 = 10;
            double valor2 = 5;
            string operador = "/";
            double resultadoEsperado = 2;

            // Act
            double resultado = Calculadora.Calcular(valor1, valor2, operador);

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Fact]
        public void TesteDivisaoPorZero()
        {
            // Arrange
            double valor1 = 10;
            double valor2 = 0;
            string operador = "/";
            string mensagemEsperada = "Erro: divisão por zero.";

            // Act
            Exception ex = Assert.Throws<Exception>(() => Calculadora.Calcular(valor1, valor2, operador));

            // Assert
            Assert.Equal(mensagemEsperada, ex.Message);
        }

        [Fact]
        public void TesteOperadorInvalido()
        {
            // Arrange
            double valor1 = 10;
            double valor2 = 5;
            string operador = "#";
            string mensagemEsperada = "Erro: Operador inválido.";

            // Act
            Exception ex = Assert.Throws<Exception>(() => Calculadora.Calcular(valor1, valor2, operador));

            // Assert
            Assert.Equal(mensagemEsperada, ex.Message);
        }
    }