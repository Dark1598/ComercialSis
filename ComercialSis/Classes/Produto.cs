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
            var cmd = Banco.Abrir();
            // inserir valores tabela
            cmd.CommandText = "insert produtos values " +
                "(0, '" + Descricao + "' ," +
                " '" + CodBar + "'," +
                " '" + Valor + "' ," +
                " '" + Desconto + "');";
            cmd.ExecuteNonQuery();
            // atribuir id a propriedade id
            // fecha a conexao
        }

        public List<Produto> Listar() // lista todos os produtos
        {
            List<Produto> Lista = new List<Produto>();
            // conectar ao banco
            var cmd = Banco.Abrir();
            // buscar registros na tabela
            cmd.CommandText = "select * from produtos";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Lista.Add(new Produto(
                dr.GetInt32(0),
                dr.GetString(1),
                dr.GetString(2),
                dr.GetDouble(3),
                dr.GetDouble(4)
                ));
            }
            // atribuir registros a lista
            // fecha a conexao
            // entregar lista pra quem solicitou
            return Lista;
        }
        public void BuscarPorId(int id) // lista todos os produtos
        {
            List<Produto> Lista = new List<Produto>();
            // conectar ao banco
            var cmd = Banco.Abrir();
            // buscar registros na tabela
            cmd.CommandText = "select * from produtos where id = " + id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Descricao = dr.GetString(1);
                CodBar = dr.GetString(2);
                Valor = dr.GetDouble(3);
                Desconto = dr.GetDouble(4);
            }
        }
        public bool Alterar(int id)
        {
            bool alterado = false;
            // conectar ao banco
            var cmd = Banco.Abrir();
            // buscar registros na tabela a ser alterado

            // atribuir os valores a propriedades
            cmd.CommandText = "update produtos " +
            "set descricao = '" + Descricao + "', " +
            "cod_bar = '" + CodBar + "', " +
            "valor = '" + Valor + "', " +
            "desconto = '" + Desconto + "' " +
            "where id = " + id;

            // registra a alteracao
            try
            {
                cmd.ExecuteNonQuery();
                alterado = true;
            }
            catch (Exception)
            {
                throw;
            }
            // indica a validacao (alterado com sussesso)
            // fecha a conexao
            return alterado;
        }
    }
}
