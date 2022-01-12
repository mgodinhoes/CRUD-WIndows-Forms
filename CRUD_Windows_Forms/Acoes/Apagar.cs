using CRUD_Windows_Forms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Windows_Forms.Acoes
{
    class Apagar
    {

        public Apagar(Series serie)
        {
            if (serie == null)
            {
                return;
            }

            if (Series.ListaSeries.Contains(serie))
            {
                Series.ListaSeries.Remove(serie);
                MessageBox.Show(serie.titulo + " apagado com sucesso.");
                
                return;
            }

            MessageBox.Show($"{serie.titulo} já apagado.");
        }
    }
}
