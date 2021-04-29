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
            var cmd = Banco.Abrir();
            // inserir valores tabela
            cmd.CommandText = "insert clientes values (0, '"+Nome+"' , '"+Cpf+"', '"+Email+"' , '"+Telefone+"' , default, md5('123456'));";
            cmd.ExecuteNonQuery();
            // atribuir id a propriedade id
            cmd.CommandText = "select @@identity";
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            // fecha a conexao
        }

        public List<Cliente> Listar() // lista todos os produtos
        {
            List<Cliente> Lista = new List<Cliente>();
            // conectar ao banco
            var cmd = Banco.Abrir();
            // buscar registros na tabela
            cmd.CommandText = "select * from clientes";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Lista.Add(new Cliente(
                dr.GetInt32(0),
                dr.GetString(1),
                dr.GetString(2),
                dr.GetString(3),
                dr.GetString(4),
                dr.GetString(6),
                dr.GetDateTime(5)
                ));
            } 
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
                Cpf = dr.GetString(2);
                Email = dr.GetString(3);
                Telefone = dr.GetString(4);
                DataCad = dr.GetDateTime(5);
                Senha = dr.GetString(6);
            }
            // atribuir os valores a propriedades
            // fecha a conexao
        }
        public bool Alterar(int id)
        {
            bool alterado = false;
            // conectar ao banco
            var cmd = Banco.Abrir();
            // buscar registros na tabela a ser alterado

            // atribuir os valores a propriedades
            cmd.CommandText = "update clientes " +
            "set nome = '" + Nome + "', " +
            "email = '" + Email + "', " +
            "telefone = '" + Telefone + "', " +
            "senha = md5('" + Senha + "') " +
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
