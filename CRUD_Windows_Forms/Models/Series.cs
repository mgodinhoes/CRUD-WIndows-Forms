using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Windows_Forms.Models
{
    public class Series
    {
        public int id { get; set; }
        public string genero { get; set; }
        public string titulo { get; set; }
        public string ano { get; set; }
        public string descricao { get; set; }




        public Series()
        {

        }




        public Series(int id, string genero, string titulo, string ano, string descricao)
        {
            this.id = id;
            this.genero = genero;
            this.titulo = titulo;
            this.ano = ano;
            this.descricao = descricao;
        }

        //Banco de dados
        public static List<Series> ListaSeries = new List<Series>();

        public static void popularLista()
        {
            if (!ListaSeries.Any())
            {
                ListaSeries.Add(new Series() { id = 0, ano = "1999", descricao = "Mary Cosmos enfrenta o maior desafio quando a Terra é assolada por uma grande seca, faltando escasses de alimentos", genero = "Ficção", titulo = "A Seca" });
                ListaSeries.Add(new Series() { id = 1, ano = "2000", descricao = "Dois em um é uma comédia hilariante, onde um jovem tentar conquistar uma garota Nerd, que não tem a mínima atração por ele.", genero = "Comédia", titulo = "Dois em um" });
                ListaSeries.Add(new Series() { id = 2, ano = "1996", descricao = "Garret enfrenta o maior desafio quando perdeu o emprego, e teve que se reiventar para continuar os desafios de sustentar sua família", genero = "Drama", titulo = "O desafio" });
            }

        }

        /// <summary>
        /// Mostra a quantidade de séries
        /// </summary>
        /// <returns></returns>
        public static int qtdSeries()
        {
            return ListaSeries.Count;
        }

        public static void setaListBox (ListBox listBox)
            {
            listBox.DataSource = null;
            listBox.Items.Clear();
            listBox.DataSource = Series.ListaSeries;
            listBox.ValueMember = "id";
            listBox.DisplayMember = "titulo";
            listBox.Update();
            }


}
}
