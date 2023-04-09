namespace RepreductroMP4
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_reproducir = new System.Windows.Forms.Button();
            this.txt_url = new System.Windows.Forms.TextBox();
            this.wmp = new AxWMPLib.AxWindowsMediaPlayer();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.wmp)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_reproducir
            // 
            this.btn_reproducir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reproducir.Location = new System.Drawing.Point(0, 28);
            this.btn_reproducir.Name = "btn_reproducir";
            this.btn_reproducir.Size = new System.Drawing.Size(145, 27);
            this.btn_reproducir.TabIndex = 1;
            this.btn_reproducir.Text = "REPRODUCIR";
            this.btn_reproducir.UseVisualStyleBackColor = true;
            this.btn_reproducir.Click += new System.EventHandler(this.btn_reproducir_Click);
            // 
            // txt_url
            // 
            this.txt_url.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_url.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_url.Location = new System.Drawing.Point(0, 0);
            this.txt_url.Name = "txt_url";
            this.txt_url.Size = new System.Drawing.Size(825, 22);
            this.txt_url.TabIndex = 2;
            this.txt_url.Text = "Pegar la ruta de acceso del video que desees reproducir";
            // 
            // wmp
            // 
            this.wmp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wmp.Enabled = true;
            this.wmp.Location = new System.Drawing.Point(0, 0);
            this.wmp.Name = "wmp";
            this.wmp.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmp.OcxState")));
            this.wmp.Size = new System.Drawing.Size(825, 459);
            this.wmp.TabIndex = 0;
            //this.wmp.Enter += new System.EventHandler(this.wmp_Enter);
            // 
            // openFileDialog1
            // 
            //this.openFileDialog1.FileName = "Buscar video";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 459);
            this.Controls.Add(this.txt_url);
            this.Controls.Add(this.btn_reproducir);
            this.Controls.Add(this.wmp);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.wmp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer wmp;
        private System.Windows.Forms.Button btn_reproducir;
        private System.Windows.Forms.TextBox txt_url;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

