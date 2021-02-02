using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace ProjetoLocadora
{
    public partial class BuscaUsuario : Form
    {
        string nome,cod,nom,nivel;
        int codigo;
        SqlDataReader leitor;
        public BuscaUsuario()
        {
            InitializeComponent();
        }

        private void botaoConsultausuario_Click(object sender, EventArgs e)
        {
            ListViewBuscaUsuario.Items.Clear();
            nome = textbuscausuario.Text;
            SqlConnection conexao = new SqlConnection("Data Source = (Local); Initial Catalog = LOCADORA; Integrated Security=SSPI");
            conexao.Open();

            SqlCommand selecionafilme = new SqlCommand("select Cod_Us,Nome_Us,nivel_acesso from Acesso_Usuario where Nome_Us like '%" + nome + "%'", conexao);

            leitor = selecionafilme.ExecuteReader();

            if (leitor.Read() == false)
            {
                MessageBox.Show("Usuário inexistente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textbuscausuario.Clear();
            }
            leitor.Close();

            leitor= selecionafilme.ExecuteReader();
           
                while (leitor.Read() == true)
                {
                    cod = leitor["Cod_Us"].ToString();
                    nom = leitor["Nome_Us"].ToString();
                    nivel = leitor["nivel_acesso"].ToString();


                    ListViewItem itemLista = new ListViewItem(cod);
                    ListViewItem.ListViewSubItem subitemLista = new ListViewItem.ListViewSubItem(itemLista, nom);
                    itemLista.SubItems.Add(subitemLista);
                    subitemLista = new ListViewItem.ListViewSubItem(itemLista, nivel);
                    itemLista.SubItems.Add(subitemLista);

                    ListViewBuscaUsuario.Items.Add(itemLista);

                    codigo = int.Parse(leitor["Cod_Us"].ToString());
                    botaoSelecionarUsuario.Enabled = true;

                }
                leitor.Close();
                conexao.Close();
            
        }

        private void botaoSelecionarUsuario_Click(object sender, EventArgs e)
        {
             textbuscausuario.Text = "";
             ListViewBuscaUsuario.Items.Clear();
             AlteraUsuario alteracao = new AlteraUsuario();
             alteracao.Atribuicodigo(codigo);
             alteracao.AtribuiCampos();
             alteracao.ShowDialog();
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            ListViewBuscaUsuario.Items.Clear();
            textbuscausuario.Text = "";
        
        }
    }
}
