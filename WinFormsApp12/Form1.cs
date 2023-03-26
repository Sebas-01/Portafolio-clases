namespace WinFormsApp12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_numero.Text != "")
                {
                    float Numero = float.Parse(txt_numero.Text);
                    if (Numero >= 0 && Numero <= 100)
                    {
                        MessageBox.Show("el numero esta en el rango indicado");
                    }
                    else
                    {
                        MessageBox.Show("el numero NO esta en el rango indicado, por favor ingrese otro valor ");
                    }

                }
                else
                {
                    MessageBox.Show("NO HAY DATOS EN LA CASILLA, POR FAVOR INGRESAR UN VALOR");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR: "+ex.Message);
            }
            
        }
    }
}