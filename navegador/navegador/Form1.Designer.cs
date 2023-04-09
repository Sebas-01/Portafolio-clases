namespace navegador
{
    partial class Frm_navegador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_navegador));
            this.tStrip = new System.Windows.Forms.ToolStrip();
            this.Principal = new System.Windows.Forms.ToolStripButton();
            this.atras = new System.Windows.Forms.ToolStripButton();
            this.adelante = new System.Windows.Forms.ToolStripButton();
            this.refrescar = new System.Windows.Forms.ToolStripButton();
            this.Home = new System.Windows.Forms.ToolStripButton();
            this.Txt_URLnavegar = new System.Windows.Forms.ToolStripTextBox();
            this.buscar_URL = new System.Windows.Forms.ToolStripButton();
            this.Navegador = new System.Windows.Forms.WebBrowser();
            this.tStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tStrip
            // 
            this.tStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Principal,
            this.atras,
            this.adelante,
            this.refrescar,
            this.Home,
            this.Txt_URLnavegar,
            this.buscar_URL});
            this.tStrip.Location = new System.Drawing.Point(0, 0);
            this.tStrip.Name = "tStrip";
            this.tStrip.Size = new System.Drawing.Size(882, 31);
            this.tStrip.TabIndex = 0;
            this.tStrip.Text = "toolStrip1";
            // 
            // Principal
            // 
            this.Principal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Principal.Enabled = false;
            this.Principal.Image = ((System.Drawing.Image)(resources.GetObject("Principal.Image")));
            this.Principal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Principal.Name = "Principal";
            this.Principal.Size = new System.Drawing.Size(29, 28);
            this.Principal.Text = "toolStripButton1";
            // 
            // atras
            // 
            this.atras.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.atras.Image = ((System.Drawing.Image)(resources.GetObject("atras.Image")));
            this.atras.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.atras.Name = "atras";
            this.atras.Size = new System.Drawing.Size(29, 24);
            this.atras.Text = "toolStripButton2";
            this.atras.Click += new System.EventHandler(this.atras_Click);
            // 
            // adelante
            // 
            this.adelante.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.adelante.Image = ((System.Drawing.Image)(resources.GetObject("adelante.Image")));
            this.adelante.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.adelante.Name = "adelante";
            this.adelante.Size = new System.Drawing.Size(29, 24);
            this.adelante.Text = "toolStripButton3";
            this.adelante.Click += new System.EventHandler(this.adelante_Click);
            // 
            // refrescar
            // 
            this.refrescar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.refrescar.Image = ((System.Drawing.Image)(resources.GetObject("refrescar.Image")));
            this.refrescar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refrescar.Name = "refrescar";
            this.refrescar.Size = new System.Drawing.Size(29, 24);
            this.refrescar.Text = "toolStripButton4";
            this.refrescar.Click += new System.EventHandler(this.refrescar_Click);
            // 
            // Home
            // 
            this.Home.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Home.Image = ((System.Drawing.Image)(resources.GetObject("Home.Image")));
            this.Home.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(29, 24);
            this.Home.Text = "toolStripButton5";
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // Txt_URLnavegar
            // 
            this.Txt_URLnavegar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Txt_URLnavegar.Name = "Txt_URLnavegar";
            this.Txt_URLnavegar.Size = new System.Drawing.Size(600, 31);
            // 
            // buscar_URL
            // 
            this.buscar_URL.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buscar_URL.Image = ((System.Drawing.Image)(resources.GetObject("buscar_URL.Image")));
            this.buscar_URL.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buscar_URL.Name = "buscar_URL";
            this.buscar_URL.Size = new System.Drawing.Size(29, 24);
            this.buscar_URL.Text = "toolStripButton6";
            this.buscar_URL.Click += new System.EventHandler(this.buscar_URL_Click);
            // 
            // Navegador
            // 
            this.Navegador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Navegador.Location = new System.Drawing.Point(0, 31);
            this.Navegador.MinimumSize = new System.Drawing.Size(20, 20);
            this.Navegador.Name = "Navegador";
            this.Navegador.Size = new System.Drawing.Size(882, 522);
            this.Navegador.TabIndex = 1;
            // 
            // Frm_navegador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.Navegador);
            this.Controls.Add(this.tStrip);
            this.Name = "Frm_navegador";
            this.Text = "Navegador";
            this.tStrip.ResumeLayout(false);
            this.tStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tStrip;
        private System.Windows.Forms.ToolStripButton Principal;
        private System.Windows.Forms.ToolStripButton atras;
        private System.Windows.Forms.ToolStripButton adelante;
        private System.Windows.Forms.ToolStripButton refrescar;
        private System.Windows.Forms.ToolStripButton Home;
        private System.Windows.Forms.ToolStripTextBox Txt_URLnavegar;
        private System.Windows.Forms.ToolStripButton buscar_URL;
        private System.Windows.Forms.WebBrowser Navegador;
    }
}

