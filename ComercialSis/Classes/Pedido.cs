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
        public List <Item> Items { get; set; }
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
        public Pedido(Cliente cliente, Usuario usuario)
        {
            Cliente = cliente;
            Usuario = usuario;
            Desconto = 0.0;
        }
        // métodos  - "funcionalidades"
        public void Inserir()
        {
            // conectar ao banco
            // inserir valores na tabela 
            // atribuir id a Propriedade Id
            // fecha a concexao
        }
        public List<Pedido> Listar() // lista todos os pedidos
        {
            List<Pedido> lista = new List<Pedido>();
            // conectar ao banco
            // buscar registros na tabela 
            // atribuir registros à lista
            // fecha a concexao
            // entregar lista pra quem chamou
            return lista;
        }
        public void BuscarPorId(int id) // lista todos os pedido
        {
            // conectar ao banco
            // buscar o registro na tabela  
            // atribuir os valores às propriedades
            // fecha a concexao
        }
        public bool Alterar(int id)
        {
            bool alterado = false;
            // conectar ao banco
            // buscar o registro na tabela  a ser alterado 
            // atribuir os valores às propriedades
            // registra a alteração
            // indica a validação (alterado com sucesso ou não)
            // fecha a concexao
            return alterado;
        }
        public double ObterValor(int id)
        {
            double valor = 0.00;
            // conectar ao banco
            // buscar o registro na tabela  a ser calculado 
            // atribuir o valor à variável
            // fecha a concexao
            return valor;

        }
    }
}