using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDDotNet
{
    class produto
    {
        string nome,descricao ;
        int idCategoria, idFornecedor;
        string preco;

        public string Nome { get => nome; set => nome = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public int IdCategoria { get => idCategoria; set => idCategoria = value; }
        public int IdFornecedor { get => idFornecedor; set => idFornecedor = value; }
        public string Preco { get => preco; set => preco = value; }
    }
}
