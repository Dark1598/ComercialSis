using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComercialSis.Classes
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Senha { get; set; }
        public DateTime DataCad { get; set; }
        public Cliente()
        {

        }
        public Cliente(int id, string nome, string cpf, string email, string telefone, string senha, DateTime dataCad)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Telefone = telefone;
            Senha = senha;
            DataCad = dataCad;
        }
        public Cliente(string nome, string cpf, string email, string telefone, string senha, DateTime dataCad)
        {
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Telefone = telefone;
            Senha = senha;
            DataCad = dataCad;
        }
        public Cliente(string nome, string cpf, string email, string telefone, string senha)
        {
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Telefone = telefone;
            Senha = senha;
        }
                // metodos - "funcionalidades"

        public void Inserir() 
        {
            // conectar ao banco
            // inserir valores tabela
            // atribuir id a propriedade id
            // fecha a conexao
        }

        public List<Cliente> Listar() // lista todos os produtos
        {
            List<Cliente> Lista = new List<Cliente>();
            // conectar ao banco
            // buscar registros na tabela
            // atribuir registros a lista
            // fecha a conexao
            // entregar lista pra quem solicitou
            return Lista;
        }
        public void BuscarPorId(int id) // lista todos os produtos
        {
            List<Cliente> Lista = new List<Cliente>();
            // conectar ao banco
            var cmd = Banco.Abrir();
            // buscar registros na tabela
            cmd.CommandText = "select * from clientes where id = " + id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Id = dr.GetInt32(0);
                Nome = dr.GetString(1);
            }
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
