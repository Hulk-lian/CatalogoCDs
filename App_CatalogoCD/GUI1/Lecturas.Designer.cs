﻿namespace App_CatalogoCD
{
    partial class Lecturas
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
            this.txbResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txbResultado
            // 
            this.txbResultado.Location = new System.Drawing.Point(13, 13);
            this.txbResultado.Multiline = true;
            this.txbResultado.Name = "txbResultado";
            this.txbResultado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbResultado.Size = new System.Drawing.Size(559, 336);
            this.txbResultado.TabIndex = 0;
            // 
            // Lecturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.txbResultado);
            this.Name = "Lecturas";
            this.Text = "Lecturas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbResultado;
    }
}