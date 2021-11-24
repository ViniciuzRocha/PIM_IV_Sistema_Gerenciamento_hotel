using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM_IV_MODEL
{
    public static class Validacoes
    {
        public static bool camposvalidados(Control.ControlCollection colecao)
        {
            bool campo = true;
            foreach (object item in colecao)
            {
                if (item is TextBox || item is MaskedTextBox)
                {
                    TextBoxBase textos = item as TextBoxBase;
                    if (textos.Text == "")
                    {
                        campo = false;
                        break;
                    }
                }
                if (item is ComboBox)
                {
                    ComboBox combo = item as ComboBox;
                    if (combo.SelectedItem == null)
                    {
                        campo = false;
                        break;
                    }
                }

            }
            return campo;
        }
    }
}
