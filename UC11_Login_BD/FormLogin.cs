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
            try
            {
                conexao.Open();
                comando.CommandText = "SELECT usuario, senha FROM usuarios WHERE usuario = '" + textBoxUSUARIO.Text + "' AND senha = '" + textBoxSENHA.Text + "';";

                MySqlDataReader resultadoPesquisa = comando.ExecuteReader();

                if (resultadoPesquisa.Read())
                {
                    MessageBox.Show("Usuário e Senha Corretos! Você está logado!");
                    textBoxUSUARIO.Clear();
                    textBoxSENHA.Clear();
                }
                else
                {
                    MessageBox.Show("Usuário e/ou Senha Incorreto, Por favor verifique novamente! ");
                    textBoxSENHA.Clear();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao cadastrar o usuário.Fale com o administrador do sistema.");
            }
            finally
            {
                conexao.Close();
            }
        }

        private void buttonLIMPAR_Click(object sender, EventArgs e)
        {
            textBoxUSUARIO.Clear();
            textBoxSENHA.Clear();
        }

        private void buttonCADASTRAR_Click(object sender, EventArgs e)
        {
            bool novoUsuario = true;

            try
            {
                conexao.Open();
                comando.CommandText = "SELECT usuario, senha FROM usuarios WHERE usuario = '" + textBoxUSUARIO.Text + "' AND senha = '" + textBoxSENHA.Text + "';";

                MySqlDataReader resultadoPesquisa = comando.ExecuteReader();

                if (resultadoPesquisa.Read())
                {
                    novoUsuario = false;
                    MessageBox.Show("Usuário já Cadastrado! Tente outro Usuário!");
                    textBoxUSUARIO.Clear();
                    textBoxSENHA.Clear();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao cadastrar o usuário.Fale com o administrador do sistema.");
            }
            finally
            {
                conexao.Close();
            }

            /// ---------------- ///

            if (novoUsuario)
            {
                try
                {
                    conexao.Open();
                    comando.CommandText = "INSERT INTO usuarios(usuario, senha) VALUES ('" + textBoxUSUARIO.Text + "', '" + textBoxSENHA.Text + "');";
                    comando.ExecuteNonQuery();
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro ao cadastrar o usuário. Fale com o administrador do sistema.");
                }
                finally
                {
                    conexao.Close();
                    MessageBox.Show("Cadastrado com sucesso!");
                }
                textBoxUSUARIO.Clear();
                textBoxSENHA.Clear();
            }
        }
        private void buttonFECHAR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Obrigado por utilizar nosso Programa de Cadastro!");
            Application.Exit();
        }
    }
}
