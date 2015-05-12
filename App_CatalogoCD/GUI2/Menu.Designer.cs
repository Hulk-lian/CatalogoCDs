namespace App_CatalogoCD
{
    partial class Menu
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
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.btn_leer = new System.Windows.Forms.Button();
            this.btn_leerXML = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_modif = new System.Windows.Forms.Button();
            this.btn_saveXML = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(100, 9);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(582, 29);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Menú de configuración y visualización del catálogo";
            // 
            // btn_leer
            // 
            this.btn_leer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_leer.Location = new System.Drawing.Point(234, 85);
            this.btn_leer.Name = "btn_leer";
            this.btn_leer.Size = new System.Drawing.Size(291, 29);
            this.btn_leer.TabIndex = 1;
            this.btn_leer.Text = "Leer Todos los DVD\'s";
            this.btn_leer.UseVisualStyleBackColor = true;
            // 
            // btn_leerXML
            // 
            this.btn_leerXML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_leerXML.Location = new System.Drawing.Point(234, 129);
            this.btn_leerXML.Name = "btn_leerXML";
            this.btn_leerXML.Size = new System.Drawing.Size(291, 29);
            this.btn_leerXML.TabIndex = 2;
            this.btn_leerXML.Text = "Leer Todos los DVD\'s en un XML";
            this.btn_leerXML.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Location = new System.Drawing.Point(234, 170);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(291, 29);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = "Añadir un DVD con datos al azar";
            this.btn_add.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Location = new System.Drawing.Point(234, 211);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(291, 29);
            this.btn_delete.TabIndex = 4;
            this.btn_delete.Text = "Eliminar un DVD";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_modif
            // 
            this.btn_modif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modif.Location = new System.Drawing.Point(234, 249);
            this.btn_modif.Name = "btn_modif";
            this.btn_modif.Size = new System.Drawing.Size(291, 29);
            this.btn_modif.TabIndex = 5;
            this.btn_modif.Text = "Modificar un DVD";
            this.btn_modif.UseVisualStyleBackColor = true;
            // 
            // btn_saveXML
            // 
            this.btn_saveXML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_saveXML.Location = new System.Drawing.Point(234, 287);
            this.btn_saveXML.Name = "btn_saveXML";
            this.btn_saveXML.Size = new System.Drawing.Size(291, 29);
            this.btn_saveXML.TabIndex = 6;
            this.btn_saveXML.Text = "Volcar XML a fichero";
            this.btn_saveXML.UseVisualStyleBackColor = true;
            // 
            // btn_salir
            // 
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir.Location = new System.Drawing.Point(234, 381);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(291, 29);
            this.btn_salir.TabIndex = 7;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.ClientSize = new System.Drawing.Size(784, 442);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_saveXML);
            this.Controls.Add(this.btn_modif);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_leerXML);
            this.Controls.Add(this.btn_leer);
            this.Controls.Add(this.lbl_titulo);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Button btn_leer;
        private System.Windows.Forms.Button btn_leerXML;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_modif;
        private System.Windows.Forms.Button btn_saveXML;
        private System.Windows.Forms.Button btn_salir;
    }
}