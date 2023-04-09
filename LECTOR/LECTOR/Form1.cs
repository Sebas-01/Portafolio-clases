using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LECTOR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void abrirPDF_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            lec_PDF.src= openFileDialog1.FileName;
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cerrando ventana");
            Close();
        }
    }
}
