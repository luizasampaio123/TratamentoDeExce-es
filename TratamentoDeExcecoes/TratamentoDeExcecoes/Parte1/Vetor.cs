using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TratamentoDeExcecoes.Parte1
{
    internal static class Vetor
    {
        public static void AdicionarNumeros()
        {
            int[] v = new int[10];
            string aux;
            int p = 0, n=0;
            do
            {
                Console.WriteLine("Digite o número e a posição que deseja adiciona-lo");
               
                try
                {
                    n = int.Parse(Console.ReadLine());
                    p = int.Parse(Console.ReadLine());
                    v[p] = n;
                    Console.WriteLine("Número adicionado com sucesso!!");
                    Console.WriteLine("-------------------------------------------");
                }
                catch (IndexOutOfRangeException)
                {

                    Console.WriteLine("Essa posição não existe no vetor!");

                }

                catch (FormatException) {
                    Console.WriteLine("O valor informado não é um numero!!");
                }

                Console.WriteLine("Deseja continuar?");
                aux = Console.ReadLine();

            } while( aux=="Sim"||aux=="sim");  



               
        }
    }
}
