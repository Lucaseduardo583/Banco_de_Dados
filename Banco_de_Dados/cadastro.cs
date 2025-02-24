using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco_de_Dados
{
    public partial class cadastro : Form
    {
        public cadastro()
        {
            InitializeComponent();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_nome.Text) || string.IsNullOrWhiteSpace(txt_sobre.Text) ||
        string.IsNullOrWhiteSpace(txt_cidade.Text) || string.IsNullOrWhiteSpace(txt_box_estado.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos antes de cadastrar.", "Campos Obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            MySqlConnection conexao = new MySqlConnection("server=localhost;user=root;database=bd_dados;password=;");
            MySqlCommand comando = new MySqlCommand("INSERT INTO dados (nome, sobrenome, cidade, estado) VALUES (@Nome, @Sobrenome, @Cidade, @Estado)", conexao);

            comando.Parameters.AddWithValue("@Nome", txt_nome.Text);
            comando.Parameters.AddWithValue("@Sobrenome", txt_sobre.Text);
            comando.Parameters.AddWithValue("@Cidade", txt_cidade.Text);
            comando.Parameters.AddWithValue("@Estado", txt_box_estado.Text);

            conexao.Open();
            int rowsAffected = comando.ExecuteNonQuery();
            conexao.Close();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Dados inseridos com sucesso!");
            }
            else
            {
                MessageBox.Show("Falha ao inserir dados. ");
            }
        }

        private void txt_box_estado_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_sobre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_cidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();

            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
