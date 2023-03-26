namespace Hallar_hipotenusa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            tmr_limpiar.Enabled = true;
            try
            {
                
                if (txt_opuesto.Text != "" && txt_adyacente.Text != "")
                {
                    double H;
                    double Adyacente = double.Parse(txt_adyacente.Text);
                    double Opuesto = double.Parse(txt_opuesto.Text);

                    H = Math.Sqrt((Opuesto * Opuesto) + (Adyacente * Adyacente));

                    lbl_hipotenusa.Text = "la Hipotenusa de este triangulo es: " + H;
                }
                else
                {
                    MessageBox.Show("¡¡ POR FAVOR REVISE QUE TODAS LAS CASILLAS ESTEN LLENAS O TENGAN ALGUN VALOR!!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR: "+ ex.Message);
            }
            
        }

        private void tmr_limpiar_Tick(object sender, EventArgs e)
        {
            txt_adyacente.Text = "";
            txt_opuesto.Text = "";
            lbl_hipotenusa.Text = "hipotenusa:";
            tmr_limpiar.Enabled = false;
        }
    }
}