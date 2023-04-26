using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace UC11_Login_BD
{
    public partial class FormLogin : Form
    {
        string servidor;
        MySqlConnection conexao;
        MySqlCommand comando;

        public FormLogin()
        {
            InitializeComponent();
            
            servidor = "Server=localhost;Database=login_bd;Uid=root;Pwd=";
            conexao = new MySqlConnection(servidor);
            comando = conexao.CreateCommand();
        }

        private void buttonENTRAR_Click(object sender, EventArgs e)
        {

        }

        private void buttonLIMPAR_Click(object sender, EventArgs e)
        {
            textBoxUSUARIO.Clear();
            textBoxSENHA.Clear();
        }

        private void buttonCADASTRAR_Click(object sender, EventArgs e)
        {
            conexao.Open();
            comando.CommandText = "INSERT INTO usuarios(usuario, senha) VALUES ('" + textBoxUSUARIO.Text + "', '" + textBoxSENHA.Text + "');";
            
            try
            {
                comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            finally
            {

            }
            MessageBox.Show("Cadastrado com sucesso!");
        }

        private void buttonFECHAR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Obrigado por utilizar nosso Programa de Cadastro!");
            Application.Exit();                        
        }
    }
}
