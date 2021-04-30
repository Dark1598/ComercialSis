using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComercialSis.Classes;

namespace ComercialSis
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.BuscarPorId(int.Parse(txtId.Text));
            txtNome.Text = usuario.Nome;
            txtEmail.Text = usuario.Email;
            txtSenha.Text = usuario.Senha;
            txtNivel.Text = usuario.Nivel;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Usuario usuario = new Usuario();
            List<Usuario> lista = usuario.Listar();
            foreach (var registro in lista)
            {
                listBox1.Items.Add(registro.Nome + " - " + registro.Nivel);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.Nome = txtNome.Text;
            usuario.Email = txtEmail.Text;
            usuario.Senha = txtSenha.Text;
            usuario.Nivel = txtNivel.Text;
            usuario.Inserir();
            txtId.Text = usuario.Id.ToString();
            MessageBox.Show("Usuario inserido com Sucesso!!!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.Nome = txtNome.Text;
            usuario.Email = txtEmail.Text;
            usuario.Senha = txtSenha.Text;
            usuario.Nivel = txtNivel.Text;
            if (usuario.Alterar(int.Parse(txtId.Text)))
            {
                MessageBox.Show("Usuario alterado com Sucesso");
            }
        }
    }
}
