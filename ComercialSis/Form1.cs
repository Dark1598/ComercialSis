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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.BuscarPorId(int.Parse(txtId.Text));
            txtNome.Text = cliente.Nome;
            txtCpf.Text = cliente.Cpf;
            txtEmail.Text = cliente.Email;
            txtTelefone.Text = cliente.Telefone;
            txtDataCad.Text = cliente.DataCad.ToString();
            txtSenha.Text = cliente.Senha;
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Cliente cliente = new Cliente();
            List<Cliente> lista = cliente.Listar();
            foreach (var registro in lista)
            {
                listBox1.Items.Add(registro.Nome + " - " + registro.Senha);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Nome = txtNome.Text;
            cliente.Cpf = txtCpf.Text;
            cliente.Email = txtEmail.Text;
            cliente.Telefone = txtTelefone.Text;
            cliente.Senha = txtSenha.Text;
            cliente.Inserir();
            txtId.Text = cliente.Id.ToString();
            MessageBox.Show("Cliente iserido com Sucesso!!!");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Nome = txtNome.Text;
            cliente.Email = txtEmail.Text;
            cliente.Telefone = txtTelefone.Text;
            cliente.Senha = txtSenha.Text;
            if (cliente.Alterar(int.Parse(txtId.Text)))
            {
                MessageBox.Show("Cliente alterado com Sucesso");
            }

        }
    }
}
