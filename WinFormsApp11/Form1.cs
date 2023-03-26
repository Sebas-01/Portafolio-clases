namespace WinFormsApp11
{
    public partial class Form1 : Form
    {
        float NUMERO;
        public Form1()
        {
            InitializeComponent();
        }

        

        

        private void btn_ptvo_ngtvo_Click_1(object sender, EventArgs e)
        {

            try
            {
              if (txt_numero.Text == "")
              {
                MessageBox.Show("¡¡ POR FAVOR INGRESE UN NUMERO EN LA CASILLA!!");
              }
              else
              {
                NUMERO = float.Parse(txt_numero.Text);

                if (NUMERO < 0)
                {
                 MessageBox.Show("el numero " + NUMERO + " es negativo");
                }
                else
                {
                 MessageBox.Show("el numero " + NUMERO + " es positivo");
                }
              }
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR: "+ ex.Message);
            }
            
            
        }

        private void btn_par_impar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_numero.Text == "")
                {
                    MessageBox.Show("¡¡ POR FAVOR INGRESE UN NUMERO EN LA CASILLA!!");
                }
                else
                {
                    NUMERO = float.Parse(txt_numero.Text);

                    if (NUMERO / 2 == 0)
                    {
                        MessageBox.Show("el numero " + NUMERO + " es PAR");
                    }
                    else
                    {
                        MessageBox.Show("el numero " + NUMERO + " es IMPAR");
                    }
                }

            }  
            catch(Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }

            
        }
    }
}