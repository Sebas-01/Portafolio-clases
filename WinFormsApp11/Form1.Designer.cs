namespace WinFormsApp11
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl1 = new System.Windows.Forms.Label();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.btn_par_impar = new System.Windows.Forms.Button();
            this.lbl_options = new System.Windows.Forms.Label();
            this.btn_ptvo_ngtvo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(12, 31);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(195, 20);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Por favor ingrese un numero";
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(229, 31);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(61, 27);
            this.txt_numero.TabIndex = 1;
            // 
            // btn_par_impar
            // 
            this.btn_par_impar.Location = new System.Drawing.Point(323, 352);
            this.btn_par_impar.Name = "btn_par_impar";
            this.btn_par_impar.Size = new System.Drawing.Size(156, 48);
            this.btn_par_impar.TabIndex = 3;
            this.btn_par_impar.Text = "OPERACION 2";
            this.btn_par_impar.UseVisualStyleBackColor = true;
            this.btn_par_impar.Click += new System.EventHandler(this.btn_par_impar_Click);
            // 
            // lbl_options
            // 
            this.lbl_options.AutoSize = true;
            this.lbl_options.Location = new System.Drawing.Point(12, 159);
            this.lbl_options.Name = "lbl_options";
            this.lbl_options.Size = new System.Drawing.Size(659, 60);
            this.lbl_options.TabIndex = 4;
            this.lbl_options.Text = "Operacion 1 : esta operacion al ser ejecutada te dira si el numero ingresado es p" +
    "ositivo o negativo\r\n\r\nOperacion 2 : esta operacion al ser ejecutada te dira si e" +
    "l numero ingresado es par o impar ";
            // 
            // btn_ptvo_ngtvo
            // 
            this.btn_ptvo_ngtvo.Location = new System.Drawing.Point(12, 352);
            this.btn_ptvo_ngtvo.Name = "btn_ptvo_ngtvo";
            this.btn_ptvo_ngtvo.Size = new System.Drawing.Size(156, 48);
            this.btn_ptvo_ngtvo.TabIndex = 5;
            this.btn_ptvo_ngtvo.Text = "OPERACION 1";
            this.btn_ptvo_ngtvo.UseVisualStyleBackColor = true;
            this.btn_ptvo_ngtvo.Click += new System.EventHandler(this.btn_ptvo_ngtvo_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_ptvo_ngtvo);
            this.Controls.Add(this.lbl_options);
            this.Controls.Add(this.btn_par_impar);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.lbl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl1;
        private TextBox txt_numero;
        private Button btn_par_impar;
        private Label lbl_options;
        private Button btn_ptvo_ngtvo;
    }
}