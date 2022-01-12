using CRUD_Windows_Forms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Windows_Forms.Acoes
{
    class Listar
    {
        public string textoLista = String.Empty;

        public Listar(String filtroTitulo = null)
        {

            var consulta_ = Series.ListaSeries.Where(c => !String.IsNullOrEmpty(filtroTitulo) ? c.titulo.ToUpper().Contains(filtroTitulo.ToUpper()) : true).OrderBy(o => o.id);

            textoLista = String.Empty;

            foreach (var serie in consulta_)
            {
                textoLista += "Id: \t\t" + (serie.id + 1).ToString("000") + Environment.NewLine;
                textoLista += "Título: \t" + serie.titulo + Environment.NewLine;
                textoLista += "Gênero: \t" + serie.genero + Environment.NewLine;
                textoLista += "Ano: \t\t" + serie.ano + Environment.NewLine;
                textoLista += "Descrição: \t" + serie.descricao + Environment.NewLine;
                textoLista += new String('-', 90) + Environment.NewLine;
            }
        }
    }
}
