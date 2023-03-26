namespace Hallar_hipotenusa
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
            this.components = new System.ComponentModel.Container();
            this.lbl_cateto_opuesto = new System.Windows.Forms.Label();
            this.lbl_cateto_adyacente = new System.Windows.Forms.Label();
            this.txt_opuesto = new System.Windows.Forms.TextBox();
            this.txt_adyacente = new System.Windows.Forms.TextBox();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.lbl_hipotenusa = new System.Windows.Forms.Label();
            this.tmr_limpiar = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbl_cateto_opuesto
            // 
            this.lbl_cateto_opuesto.AutoSize = true;
            this.lbl_cateto_opuesto.Location = new System.Drawing.Point(2, 26);
            this.lbl_cateto_opuesto.Name = "lbl_cateto_opuesto";
            this.lbl_cateto_opuesto.Size = new System.Drawing.Size(422, 20);
            this.lbl_cateto_opuesto.TabIndex = 0;
            this.lbl_cateto_opuesto.Text = "INGRESE EL VALOR DEL CATETO OPUESTO EN CENTIMETROS : ";
            // 
            // lbl_cateto_adyacente
            // 
            this.lbl_cateto_adyacente.AutoSize = true;
            this.lbl_cateto_adyacente.Location = new System.Drawing.Point(2, 71);
            this.lbl_cateto_adyacente.Name = "lbl_cateto_adyacente";
            this.lbl_cateto_adyacente.Size = new System.Drawing.Size(517, 20);
            this.lbl_cateto_adyacente.TabIndex = 1;
            this.lbl_cateto_adyacente.Text = "INGRESE POR FAVOR EL VALOR DEL CATETO ADYACENTE EN CENTIMETROS :";
            // 
            // txt_opuesto
            // 
            this.txt_opuesto.Location = new System.Drawing.Point(525, 26);
            this.txt_opuesto.Name = "txt_opuesto";
            this.txt_opuesto.Size = new System.Drawing.Size(54, 27);
            this.txt_opuesto.TabIndex = 2;
            // 
            // txt_adyacente
            // 
            this.txt_adyacente.Location = new System.Drawing.Point(525, 68);
            this.txt_adyacente.Name = "txt_adyacente";
            this.txt_adyacente.Size = new System.Drawing.Size(54, 27);
            this.txt_adyacente.TabIndex = 3;
            // 
            // btn_calcular
            // 
            this.btn_calcular.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_calcular.Location = new System.Drawing.Point(46, 360);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(124, 44);
            this.btn_calcular.TabIndex = 4;
            this.btn_calcular.Text = "CALCULAR";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // lbl_hipotenusa
            // 
            this.lbl_hipotenusa.AutoSize = true;
            this.lbl_hipotenusa.Location = new System.Drawing.Point(2, 157);
            this.lbl_hipotenusa.Name = "lbl_hipotenusa";
            this.lbl_hipotenusa.Size = new System.Drawing.Size(89, 20);
            this.lbl_hipotenusa.TabIndex = 5;
            this.lbl_hipotenusa.Text = "hipotesuna :";
            // 
            // tmr_limpiar
            // 
            this.tmr_limpiar.Interval = 7000;
            this.tmr_limpiar.Tick += new System.EventHandler(this.tmr_limpiar_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 430);
            this.Controls.Add(this.lbl_hipotenusa);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.txt_adyacente);
            this.Controls.Add(this.txt_opuesto);
            this.Controls.Add(this.lbl_cateto_adyacente);
            this.Controls.Add(this.lbl_cateto_opuesto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_cateto_opuesto;
        private Label lbl_cateto_adyacente;
        private TextBox txt_opuesto;
        private TextBox txt_adyacente;
        private Button btn_calcular;
        private Label lbl_hipotenusa;
        private System.Windows.Forms.Timer tmr_limpiar;
    }
}