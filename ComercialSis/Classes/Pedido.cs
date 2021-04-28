using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComercialSis.Classes
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public Cliente Cliente { get; set; }
        public Usuario Usuario { get; set; }
        public double Desconto { get; set; }
        public string Situacao { get; set; }
        public List<Item> Items { get; set; }
    }
}
