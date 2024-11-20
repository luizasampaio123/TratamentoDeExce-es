using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TratamentoDeExcecoes.Parte2
{
    internal class ExcecaoAcimaDeCem: Exception
    {
        public ExcecaoAcimaDeCem(string mensagem) : base(mensagem) { }
    }
}
