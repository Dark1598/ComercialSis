using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComercialSis.Classes
{
    public class Produto
    {   // atributos
        // propriedades
        public int Id { get; }
        public string Descricao { get; set; }
        public string CodBar { get; set; }
        public double Valor { get; set; }
        public double Desconto { get; set; }
        // metodos construtores

        public Produto() { }
        public Produto(int id, string descricao, string codBar, double valor, double desconto)
        {
            Id = id;
            Descricao = descricao;
            CodBar = codBar;
            Valor = valor;
            Desconto = desconto;
        }
        public Produto(string descricao, string codBar, double valor, double desconto)
        {
            Descricao = descricao;
            CodBar = codBar;
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

        public List<Produto> Listar() // lista todos os produtos
        {
            List<Produto> Lista = new List<Produto>();
            // conectar ao banco
            // buscar registros na tabela
            // atribuir registros a lista
            // fecha a conexao
            // entregar lista pra quem solicitou
            return Lista;
        }
        public void BuscarPorId(int id) // lista todos os produtos
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
    }
}
