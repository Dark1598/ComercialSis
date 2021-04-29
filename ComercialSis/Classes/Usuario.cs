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
        public string nivel { get; set; }

        public Usuario()
        {

        }
        public Usuario(int id, string nome, string email, string senha, string nivel)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Senha = senha;
            this.nivel = nivel;
        }
        public Usuario(string nome, string email, string senha, string nivel)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            this.nivel = nivel;
        }
        public Usuario(string nome, string email, string senha)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
        }
    }
}
