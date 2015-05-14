namespace App_CatalogoCD.GUI1
{
    partial class Modificaciones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txbTitulo = new System.Windows.Forms.TextBox();
            this.txbartista = new System.Windows.Forms.TextBox();
            this.txbpais = new System.Windows.Forms.TextBox();
            this.txbcomp = new System.Windows.Forms.TextBox();
            this.txbprecio = new System.Windows.Forms.TextBox();
            this.txbanio = new System.Windows.Forms.TextBox();
            this.cmbcodigos = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txbTitulo
            // 
            this.txbTitulo.Location = new System.Drawing.Point(31, 82);
            this.txbTitulo.Name = "txbTitulo";
            this.txbTitulo.Size = new System.Drawing.Size(100, 20);
            this.txbTitulo.TabIndex = 0;
            this.txbTitulo.Text = "Título";
            // 
            // txbartista
            // 
            this.txbartista.Location = new System.Drawing.Point(31, 141);
            this.txbartista.Name = "txbartista";
            this.txbartista.Size = new System.Drawing.Size(100, 20);
            this.txbartista.TabIndex = 1;
            this.txbartista.Text = "Artista";
            // 
            // txbpais
            // 
            this.txbpais.Location = new System.Drawing.Point(31, 202);
            this.txbpais.Name = "txbpais";
            this.txbpais.Size = new System.Drawing.Size(100, 20);
            this.txbpais.TabIndex = 2;
            this.txbpais.Text = "Pais";
            // 
            // txbcomp
            // 
            this.txbcomp.Location = new System.Drawing.Point(218, 82);
            this.txbcomp.Name = "txbcomp";
            this.txbcomp.Size = new System.Drawing.Size(100, 20);
            this.txbcomp.TabIndex = 3;
            this.txbcomp.Text = "Compañia";
            // 
            // txbprecio
            // 
            this.txbprecio.Location = new System.Drawing.Point(218, 141);
            this.txbprecio.Name = "txbprecio";
            this.txbprecio.Size = new System.Drawing.Size(100, 20);
            this.txbprecio.TabIndex = 4;
            this.txbprecio.Text = "Precio";
            // 
            // txbanio
            // 
            this.txbanio.Location = new System.Drawing.Point(218, 202);
            this.txbanio.Name = "txbanio";
            this.txbanio.Size = new System.Drawing.Size(100, 20);
            this.txbanio.TabIndex = 5;
            this.txbanio.Text = "Año";
            // 
            // cmbcodigos
            // 
            this.cmbcodigos.FormattingEnabled = true;
            this.cmbcodigos.Location = new System.Drawing.Point(31, 33);
            this.cmbcodigos.Name = "cmbcodigos";
            this.cmbcodigos.Size = new System.Drawing.Size(121, 21);
            this.cmbcodigos.TabIndex = 6;
            // 
            // Modificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(349, 276);
            this.Controls.Add(this.cmbcodigos);
            this.Controls.Add(this.txbanio);
            this.Controls.Add(this.txbprecio);
            this.Controls.Add(this.txbcomp);
            this.Controls.Add(this.txbpais);
            this.Controls.Add(this.txbartista);
            this.Controls.Add(this.txbTitulo);
            this.Name = "Modificaciones";
            this.Text = "Modificaciones";
            this.Load += new System.EventHandler(this.Modificaciones_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbTitulo;
        private System.Windows.Forms.TextBox txbartista;
        private System.Windows.Forms.TextBox txbpais;
        private System.Windows.Forms.TextBox txbcomp;
        private System.Windows.Forms.TextBox txbprecio;
        private System.Windows.Forms.TextBox txbanio;
        private System.Windows.Forms.ComboBox cmbcodigos;
    }
}