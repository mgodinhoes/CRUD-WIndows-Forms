using CRUD_Windows_Forms.Acoes;
using CRUD_Windows_Forms.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Windows_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Enter(object sender, EventArgs e)
        {

        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            tabControl1_SelectedIndexChanged(sender, e);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbQtdSerie.Text = Series.qtdSeries().ToString();
        }

        /// <summary>
        /// Botão inserir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnInserir(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtInsGenero.Text))
            {
                MessageBox.Show("Digite o gênero");
                return;
            }

            if (String.IsNullOrEmpty(txtInsTitulo.Text))
            {
                MessageBox.Show("Digite o título");
                return;
            }

            if (String.IsNullOrEmpty(txtInsAno.Text))
            {
                MessageBox.Show("Digite o ano");
                return;
            }

            if (String.IsNullOrEmpty(txtInsDescricao.Text))
            {
                MessageBox.Show("Digite a descrição");
                return;
            }

            Series serie = new Series(0, txtInsGenero.Text, txtInsTitulo.Text, txtInsAno.Text, txtInsDescricao.Text);
            var id = new Inserir(serie);
            lbQtdSerie.Text = Series.qtdSeries().ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtLista.Text = new Listar().textoLista;
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            Series.setaListBox(listEdiSeriesTxt);
        }

        private void listSeriesTxt_Click(object sender, EventArgs e)
        {
            var serie = ((Series)listEdiSeriesTxt.SelectedItem);
            popularCamposEditar(serie);
        }

        private void tabPage3_Enter(object sender, EventArgs e)
        {
            Series.setaListBox(listDelSeriesTxt);
        }

        private void listDelSeriesTxt_DoubleClick(object sender, EventArgs e)
        {
            var serie = ((Series)listDelSeriesTxt.SelectedItem);

            if (MessageBox.Show(this, "Apagar a série " + serie.titulo + "?", "Confirmação", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                var apagar = new Apagar(serie);
                Series.setaListBox(listDelSeriesTxt);
            }
        }

        public void popularCamposEditar(Series serie)
        {
            if (serie == null) return;

            txtEdiGenero.Text = serie.genero;
            txtEditarAno.Text = serie.ano;
            txtEditarDescricao.Text = serie.descricao;
            txtEditarTitulo.Text = serie.titulo;
        }
        private void listSeriesTxt_Enter(object sender, EventArgs e)
        {

        }

        public void limpaCampos()
        {
            txtEdiGenero.Text = "";
            txtEditarAno.Text = "";
            txtEditarDescricao.Text = "";
            txtEditarTitulo.Text = "";
        }

        /// <summary>
        /// Botão editar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditar_Click(object sender, EventArgs e)
        {
            var serie = ((Series)listEdiSeriesTxt.SelectedItem);
            //Faz a edição

            serie.ano = txtEditarAno.Text;
            serie.descricao = txtEditarDescricao.Text;
            serie.genero = txtEdiGenero.Text;
            serie.titulo = txtEditarTitulo.Text;

            var editar = new Editar(serie);

            Series.setaListBox(listEdiSeriesTxt);
        }
    }

}
