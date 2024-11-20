namespace TratamentoDeExcecoes.Parte1
{
    static class EhPrimo
    {

        public static void Primo()
        {
            int n = 0;
            int cont = 0;
            bool valido = false;
            do
            {
                Console.WriteLine("Digite um número inteiro:");

                try
                {
                    n = int.Parse(Console.ReadLine());
                    valido = true;

                }
                catch (FormatException)
                {
                    Console.WriteLine("Erro! O valor digitado não é um número inteiro válido.");
                }
            } while (!valido);

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    cont++;
                }
            }


            if (cont == 2)
            {
                Console.WriteLine("É primo");
            }

            else
            {
                Console.WriteLine("Não é primo");
            }

        }
    }
}
