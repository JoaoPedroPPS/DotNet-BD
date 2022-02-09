using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDDotNet
{
    class fornecedor
    {
        string nome;
        int cnpj;

        public string Nome { get => nome; set => nome = value; }
        public int Cnpj { get => cnpj; set => cnpj = value; }
    }
}
