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
        public Pedido() { }

        public Pedido(int id, DateTime data, Cliente cliente, Usuario usuario, double desconto, string situacao, List<Item> items)
        {
            Id = id;
            Data = data;
            Cliente = cliente;
            Usuario = usuario;
            Desconto = desconto;
            Situacao = situacao;
            Items = items;
        }
        public Pedido(DateTime data, Cliente cliente, Usuario usuario, double desconto, string situacao, List<Item> items)
        {
            Data = data;
            Cliente = cliente;
            Usuario = usuario;
            Desconto = desconto;
            Situacao = situacao;
            Items = items;
        }
        public Pedido(Cliente cliente, Usuario usuario, double desconto)
        {
            Cliente = cliente;
            Usuario = usuario;
            Desconto = 0,0;
        }
    }
}
