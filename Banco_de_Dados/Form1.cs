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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //atualizado
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form cadastro = new cadastro();
            cadastro.Show();
        }

        private void data_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MySqlConnection conexao = new MySqlConnection("server=localhost;user=root;database=bd_dados;password=;");
            MySqlCommand comando = new MySqlCommand("SELECT * FROM dados", conexao);

            DataTable dt = new DataTable();
            conexao.Open();

            MySqlDataAdapter da = new MySqlDataAdapter(comando);
            da.Fill(dt);
            conexao.Close();

            data_grid.DataSource = dt;
        }

        private void txt_box_pesquisar_TextChanged(object sender, EventArgs e)
        {
            string pesquisa = txt_box_pesquisar.Text;
            MySqlConnection conexao = new MySqlConnection("server=localhost;user=root;database=bd_dados;password=;");
            MySqlCommand comando = new MySqlCommand("SELECT * FROM dados where nome like '%" +pesquisa+"%'",conexao);

            DataTable dt = new DataTable();
            conexao.Open();

            MySqlDataAdapter da = new MySqlDataAdapter(comando);
            da.Fill(dt);
            conexao.Close();

            data_grid.DataSource = dt;
        }
    }
}
