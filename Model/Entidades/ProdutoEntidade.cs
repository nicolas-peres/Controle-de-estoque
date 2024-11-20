using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entidades
{
    public class ProdutoEntidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public float Preco { get; set; }

        public object[] Linha()
        {
            return new object[] { Id, Nome, Preco, Quantidade, Descricao };
        }
    }
}

