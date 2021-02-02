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
    public partial class BuscaFilme : Form
    {
        public string titulo, titu, cod,genero;
        int codigo;
        SqlDataReader leitor;
        Filme objFilme = new Filme();
        public BuscaFilme()
        {
            InitializeComponent();
        }

        private void botaoAdicionarFilme_Click(object sender, EventArgs e)
        {
            textFilmeTitulo.Text = "";
            listViewFilmes.Items.Clear();
            AlteraFilme alteracao = new AlteraFilme();
            alteracao.Atribuicodigo(codigo);
            alteracao.AtribuiCampos();
            alteracao.ShowDialog();
        }

        private void botaoConsultaFilme_Click(object sender, EventArgs e)
        {
            listViewFilmes.Items.Clear();
            titulo = textFilmeTitulo.Text;
            SqlConnection conexao = new SqlConnection("Data Source = (Local); Initial Catalog = LOCADORA; Integrated Security=SSPI");
            conexao.Open();

            SqlCommand selecionafilme = new SqlCommand("select Cod_Filme,Titu_Filme,genero from Filmes where Titu_Filme like '%" + titulo + "%'", conexao);

            leitor = selecionafilme.ExecuteReader();
            if (leitor.Read() == false)
            {
                MessageBox.Show("Filme inexistente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textFilmeTitulo.Clear();
            }
            leitor.Close();
            leitor=selecionafilme.ExecuteReader();

                while (leitor.Read() == true)
                {
                    cod = leitor["Cod_Filme"].ToString();
                    titu = leitor["Titu_filme"].ToString();
                    genero = leitor["genero"].ToString();


                    ListViewItem itemLista = new ListViewItem(cod);
                    ListViewItem.ListViewSubItem subitemLista = new ListViewItem.ListViewSubItem(itemLista, titu);
                    itemLista.SubItems.Add(subitemLista);
                    subitemLista = new ListViewItem.ListViewSubItem(itemLista, genero);
                    itemLista.SubItems.Add(subitemLista);

                    listViewFilmes.Items.Add(itemLista);

                    codigo = int.Parse(leitor["Cod_Filme"].ToString());
                    botaoSelecionarFilme.Enabled = true;

                }
                leitor.Close();
                conexao.Close();
            
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            listViewFilmes.Items.Clear();
            textFilmeTitulo.Text = "";

        }
    }
}