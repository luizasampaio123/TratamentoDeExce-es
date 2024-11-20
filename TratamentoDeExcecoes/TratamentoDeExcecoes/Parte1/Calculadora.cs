using System;

namespace TratamentoDeExcecoes.Parte1
{
    internal static class Calculadora
    {
        public static void Menu()
        {
            bool continuar = true;

            while (continuar)
            {
                try
                {
                    Console.WriteLine("Digite o número correspondente ao cálculo que deseja realizar:");
                    Console.WriteLine("1 - Soma");
                    Console.WriteLine("2 - Multiplicação");
                    Console.WriteLine("3 - Divisão");
                    Console.WriteLine("4 - Módulo");
                    Console.WriteLine("5 - Sair");
                    Console.WriteLine("--------------------------------------------------------------------------------");

                    int num = int.Parse(Console.ReadLine());

                    switch (num)
                    {
                        case 1:
                            Console.WriteLine($"Resultado da Soma: {Soma()}");
                            break;
                        case 2:
                            Console.WriteLine($"Resultado da Multiplicação: {Multiplicacao()}");
                            break;
                        case 3:
                            Console.WriteLine($"Resultado da Divisão: {Divisao()}");
                            break;
                        case 4:
                            Console.WriteLine($"Resultado do Módulo: {Modulo()}");
                            break;
                        case 5:
                            continuar = false;
                            break;
                        default:
                            Console.WriteLine("Opção inválida! Tente novamente.");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Erro! Entrada inválida. Digite um número de 1 a 5.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Erro! O número é muito grande.");
                }
            }
        }

        public static (int, int) ReceberValores()
        {
            int n1 = 0;
            int n2 = 0;
            bool valido = false;

            do
            {
                try
                {
                    Console.WriteLine("Digite o primeiro número inteiro:");
                    n1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o segundo número inteiro:");
                    n2 = int.Parse(Console.ReadLine());
                    valido = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Erro! O valor digitado não é um número inteiro válido.");
                }
            } while (!valido);

            return (n1, n2);
        }

        public static int Multiplicacao()
        {
            var (n1, n2) = ReceberValores();
            int resultado = 0;

            try
            {
                checked // Habilita a detecção de estouro
                {
                    resultado = n1 * n2;
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Erro: Multiplicação resultou em um estouro de capacidade.");
            }

            return resultado;
        }

        public static int Soma()
        {
            var (n1, n2) = ReceberValores();
            int resultado = 0;

            try
            {
                checked
                {
                    resultado = n1 + n2;
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Erro: Soma resultou em um estouro de capacidade.");
            }

            return resultado;
        }

        public static int Divisao()
        {
            var (n1, n2) = ReceberValores();
            int resultado = 0;

            try
            {
                if (n2 == 0)
                {
                    throw new DivideByZeroException();
                }
                resultado = n1 / n2;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Erro: Divisão por zero não é permitida.");
            }

            return resultado;
        }

        public static int Modulo()
        {
            var (n1, n2) = ReceberValores();
            int resultado = 0;

            try
            {
                if (n2 == 0)
                {
                    throw new DivideByZeroException();
                }
                resultado = n1 % n2;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Erro: Divisão por zero não é permitida no cálculo do módulo.");
            }

            return resultado;
        }
    }
}
