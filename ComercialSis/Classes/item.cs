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

        public Item() { }

        public Item(Produto produto, double quantidade, double valor, double desconto)
        {
            Produto = produto;
            Quantidade = quantidade;
            Valor = valor;
            Desconto = desconto;
        }
        // metodos - "funcionalidades"

        public void Inserir()
        {
            // conectar ao banco
            // inserir valores tabela
            // atribuir id a propriedade id
            // fecha a conexao
        }

        public List<Item> Listar() // lista todos os Itens
        {
            List<Item> Lista = new List<Item>();
            // conectar ao banco
            // buscar registros na tabela
            // atribuir registros a lista
            // fecha a conexao
            // entregar lista pra quem solicitou
            return Lista;
        }
        public void BuscarPorProdutos(Produto produto) // lista todos os produtos
        {
            List<Produto> Lista = new List<Produto>();
            // conectar ao banco
            // buscar registros na tabela
            // atribuir os valores a propriedades
            // fecha a conexao
        }
        public bool Alterar(int id)
        {
            bool alterado = false;
            // conectar ao banco
            // buscar registros na tabela a ser alterado
            // atribuir os valores a propriedades
            // registra a alteracao
            // indica a validacao (alterado com sussesso)
            // fecha a conexao
            return alterado;
        }
        public double ObterValor(Pedidos pedido)
        {
            double valor = 0.00;
        }
    }
}
