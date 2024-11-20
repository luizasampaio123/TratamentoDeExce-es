namespace TratamentoDeExcecoes.Parte2
{
    internal static class SomarNumeros
    {
        public static void Somar()
        {
            int n = 0, s = 0;

            for (int i = 1; s <= 100; i++)
            {

                Console.WriteLine("Digite um numero");

                try
                {
                    n = int.Parse(Console.ReadLine());
                    s = n + s;

                    Console.WriteLine($"Soma total={s}");
                    Console.WriteLine($"Números somados{i}");
                    Console.WriteLine($"Média dos valores somados:{s / i}");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Valores incorretos!");
                }

                if (s > 100)
                {
                    throw new ExcecaoAcimaDeCem("Soma maior que 100!");
                    break;
                }
            }
        }


    }
}
