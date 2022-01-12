using CRUD_Windows_Forms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Windows_Forms.Acoes
{
    class Inserir
    {
        /// <summary>
        /// Faz a inserção
        /// </summary>
        /// <param name="serie"></param>
        public Inserir(Series serie)
        {
            if (serie == null)
            {
                return;
            }

            if (!Series.ListaSeries.Contains(serie))
            {
                //Pega o maior id da série
                var maxIndice = Series.ListaSeries.Max(m=>m.id);
                
                //Modifica o id da série existente
                serie.id = maxIndice + 1;

                //Insere a série na lista
                Series.ListaSeries.Add(serie);

                MessageBox.Show(serie.titulo + " inserido com sucesso.");

                return;
            }

            MessageBox.Show($"{serie.titulo} já inserido");
        }


    }
}
