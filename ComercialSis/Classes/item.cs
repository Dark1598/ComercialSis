using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComercialSis.Classes
{
    public class Item
    {
        // isso é uma propriedade
        public Produto Produto { get; set; }
        public double Quantidade { get; set; }
        public double Valor { get; set; }
        public double Desconto { get; set; }
    }
}
