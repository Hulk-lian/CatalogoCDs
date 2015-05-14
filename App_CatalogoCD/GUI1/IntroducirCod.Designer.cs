namespace App_CatalogoCD
{
    partial class IntroducirCod
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
            this.txbCod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btncont = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbCod
            // 
            this.txbCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCod.Location = new System.Drawing.Point(102, 78);
            this.txbCod.Name = "txbCod";
            this.txbCod.Size = new System.Drawing.Size(147, 38);
            this.txbCod.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-4, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Introduzca el codigo del CD";
            // 
            // btncont
            // 
            this.btncont.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncont.Location = new System.Drawing.Point(116, 138);
            this.btncont.Name = "btncont";
            this.btncont.Size = new System.Drawing.Size(123, 43);
            this.btncont.TabIndex = 2;
            this.btncont.Text = "Continuar";
            this.btncont.UseVisualStyleBackColor = true;
            this.btncont.Click += new System.EventHandler(this.btncont_Click);
            // 
            // IntroducirCod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(356, 193);
            this.Controls.Add(this.btncont);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbCod);
            this.Name = "IntroducirCod";
            this.Text = "Introduzca el código";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbCod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncont;
    }
}