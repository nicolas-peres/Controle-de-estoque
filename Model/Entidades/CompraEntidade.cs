using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entidades
{
   
    class CompraEntidade
    {
        public int Id { get; set; }
        public string Produto { get; set; }
        public int Quantidade { get; set; }
        public decimal Subtotal { get; set; }
    }
}
