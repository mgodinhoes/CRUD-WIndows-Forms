using CRUD_Windows_Forms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Windows_Forms.Acoes
{
    class Editar
    {

        public Editar(Series serie)
        {
            if (serie == null)
            {
                return;
            }

            if (Series.ListaSeries.Contains(serie))
            {
                var serie_ = Series.ListaSeries.Where(c => c.id == serie.id).First();

                if (serie_ != null)
                {
                    serie_.titulo = serie.titulo;
                    serie_.descricao = serie.descricao;
                    serie_.genero = serie.genero;
                    serie_.titulo = serie.titulo;
                    MessageBox.Show(serie.titulo + " editado com sucesso.");
            
                }
            }

          
        }
    }
}
