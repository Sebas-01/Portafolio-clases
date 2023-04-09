namespace LECTOR
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.mStrip_archivo = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirPDF = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrar = new System.Windows.Forms.ToolStripMenuItem();
            this.lec_PDF = new AxAcroPDFLib.AxAcroPDF();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lec_PDF)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mStrip_archivo});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "Buscar PDF";
            // 
            // mStrip_archivo
            // 
            this.mStrip_archivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirPDF,
            this.cerrar});
            this.mStrip_archivo.Name = "mStrip_archivo";
            this.mStrip_archivo.Size = new System.Drawing.Size(60, 20);
            this.mStrip_archivo.Text = "Archivo";
            // 
            // abrirPDF
            // 
            this.abrirPDF.Name = "abrirPDF";
            this.abrirPDF.Size = new System.Drawing.Size(180, 22);
            this.abrirPDF.Text = "Abrir PDF";
            this.abrirPDF.Click += new System.EventHandler(this.abrirPDF_Click);
            // 
            // cerrar
            // 
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(180, 22);
            this.cerrar.Text = "Cerrar";
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // lec_PDF
            // 
            this.lec_PDF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lec_PDF.Enabled = true;
            this.lec_PDF.Location = new System.Drawing.Point(0, 24);
            this.lec_PDF.Name = "lec_PDF";
            this.lec_PDF.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("lec_PDF.OcxState")));
            this.lec_PDF.Size = new System.Drawing.Size(800, 426);
            this.lec_PDF.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lec_PDF);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Lector PDF";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lec_PDF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mStrip_archivo;
        private System.Windows.Forms.ToolStripMenuItem abrirPDF;
        private System.Windows.Forms.ToolStripMenuItem cerrar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private AxAcroPDFLib.AxAcroPDF lec_PDF;
    }
}

