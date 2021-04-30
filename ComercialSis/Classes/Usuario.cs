using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComercialSis.Classes
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nivel { get; set; }

        public Usuario()
        {

        }
        public Usuario(int id, string nome, string email, string senha, string nivel)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Senha = senha;
            Nivel = nivel;
        }
        public Usuario(string nome, string email, string senha, string nivel)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            Nivel = nivel;
        }
        public Usuario(string nome, string email, string senha)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
        }
        public void Inserir()
        {
            // conectar ao banco
            var cmd = Banco.Abrir();
            // inserir valores tabela
            cmd.CommandText = "insert usuarios values " +
                "(0, '"+Nome+"', '"+Email+"', md5('"+Senha+"'), '"+Nivel+"'); ; ";
            cmd.ExecuteNonQuery();
            // atribuir id a propriedade id
            cmd.CommandText = "select @@identity";
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            // fecha a conexao
        }

        public List<Usuario> Listar() // lista todos os produtos
        {
            List<Usuario> Lista = new List<Usuario>();
            // conectar ao banco
            var cmd = Banco.Abrir();
            // buscar registros na tabela
            cmd.CommandText = "select * from usuarios";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Lista.Add(new Usuario(
                dr.GetInt32(0),
                dr.GetString(1),
                dr.GetString(2),
                dr.GetString(3),
                dr.GetString(4)
                ));
            }
            // atribuir registros a lista
            // fecha a conexao
            // entregar lista pra quem solicitou
            return Lista;
        }
        public void BuscarPorId(int id) // lista todos os produtos
        {
            List<Usuario> Lista = new List<Usuario>();
            // conectar ao banco
            var cmd = Banco.Abrir();
            // buscar registros na tabela
            cmd.CommandText = "select * from usuarios where id = " + id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Id = dr.GetInt32(0);
                Nome = dr.GetString(1);
                Email = dr.GetString(2);
                Senha = dr.GetString(3);
                Nivel = dr.GetString(4);
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
            cmd.CommandText = "update usuarios " +
                "set nome = '"+Nome+"', " +
                "email = '"+Email+"', " +
                "senha = '"+Senha+"', " +
                "nivel = '"+Nivel+"' " +
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
