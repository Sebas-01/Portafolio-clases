using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace navegador
{
    public partial class Frm_navegador : Form
    {
        public Frm_navegador()
        {
            InitializeComponent();
        }

        private void buscar_URL_Click(object sender, EventArgs e)
        {
            Navegador.Navigate(Txt_URLnavegar.Text);
        }

        private void atras_Click(object sender, EventArgs e)
        {
            Navegador.GoBack();
        }

        private void adelante_Click(object sender, EventArgs e)
        {
            Navegador.GoForward();
        }

        private void refrescar_Click(object sender, EventArgs e)
        {
            Navegador.Refresh();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            Navegador.GoHome();
             
        }
    }
}
