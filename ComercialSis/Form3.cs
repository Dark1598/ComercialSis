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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            produto.Descricao = txtDescricao.Text;
            produto.CodBar = txtCodBar.Text;
            produto.Valor = Convert.ToDouble(txtValor.Text);
            produto.Desconto = Convert.ToDouble(txtDesconto.Text);
            if (produto.Alterar(int.Parse(txtId.Text)))
            {
                MessageBox.Show("Produto alterado com Sucesso");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            produto.BuscarPorId(int.Parse(txtId.Text));
            txtDescricao.Text = produto.Descricao;
            txtCodBar.Text = produto.CodBar;
            txtValor.Text = produto.Valor.ToString();
            txtDesconto.Text = produto.Desconto.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            produto.Descricao = txtDescricao.Text;
            produto.CodBar = txtCodBar.Text;
            produto.Valor = Convert.ToDouble(txtValor.Text);
            produto.Desconto = Convert.ToDouble(txtDesconto.Text);
            produto.Inserir();
            txtId.Text = produto.Id.ToString();
            MessageBox.Show("Produto inserido com Sucesso!!!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Produto produto = new Produto();
            List<Produto> lista = produto.Listar();
            foreach (var registro in lista)
            {
                listBox1.Items.Add(registro.Descricao + " - " + registro.Valor);
            }
        }
    }
}
