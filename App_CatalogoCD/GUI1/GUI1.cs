using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace App_CatalogoCD
{
    public partial class GUI1_menu : Form
    {
        private Label lblTitulo;
        private Label lblMenu;
        private Button btnXmlLeer;
        private Button btnAnadirAzar;
        private Button btnEliminar;
        private Button btnMod;
        private Button btnVolcarAxml;
        private Button btnFiltrarPais;
        private Button btnSalir;
        private Button v;
    
        public GUI1_menu()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.v = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblMenu = new System.Windows.Forms.Label();
            this.btnXmlLeer = new System.Windows.Forms.Button();
            this.btnAnadirAzar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnVolcarAxml = new System.Windows.Forms.Button();
            this.btnFiltrarPais = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // v
            // 
            this.v.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.v.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v.Location = new System.Drawing.Point(16, 131);
            this.v.Name = "v";
            this.v.Size = new System.Drawing.Size(140, 47);
            this.v.TabIndex = 0;
            this.v.Text = "Leer todos los CDs";
            this.v.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(142, 19);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(271, 31);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "CATÁLOGO DE CDs";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.Location = new System.Drawing.Point(173, 67);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(210, 25);
            this.lblMenu.TabIndex = 2;
            this.lblMenu.Text = "Selecciona una opción";
            // 
            // btnXmlLeer
            // 
            this.btnXmlLeer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXmlLeer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXmlLeer.Location = new System.Drawing.Point(204, 131);
            this.btnXmlLeer.Name = "btnXmlLeer";
            this.btnXmlLeer.Size = new System.Drawing.Size(140, 47);
            this.btnXmlLeer.TabIndex = 3;
            this.btnXmlLeer.Text = "Leer todos los DVDs en XML";
            this.btnXmlLeer.UseVisualStyleBackColor = true;
            // 
            // btnAnadirAzar
            // 
            this.btnAnadirAzar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnadirAzar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnadirAzar.Location = new System.Drawing.Point(396, 131);
            this.btnAnadirAzar.Name = "btnAnadirAzar";
            this.btnAnadirAzar.Size = new System.Drawing.Size(140, 47);
            this.btnAnadirAzar.TabIndex = 4;
            this.btnAnadirAzar.Text = "Añadir un DVD con datos al azar";
            this.btnAnadirAzar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(16, 204);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(140, 47);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar un CD";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnMod
            // 
            this.btnMod.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMod.Location = new System.Drawing.Point(204, 204);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(140, 47);
            this.btnMod.TabIndex = 6;
            this.btnMod.Text = "Modificar un CD";
            this.btnMod.UseVisualStyleBackColor = true;
            // 
            // btnVolcarAxml
            // 
            this.btnVolcarAxml.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVolcarAxml.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolcarAxml.Location = new System.Drawing.Point(396, 204);
            this.btnVolcarAxml.Name = "btnVolcarAxml";
            this.btnVolcarAxml.Size = new System.Drawing.Size(140, 47);
            this.btnVolcarAxml.TabIndex = 7;
            this.btnVolcarAxml.Text = "Volcar a XML";
            this.btnVolcarAxml.UseVisualStyleBackColor = true;
            // 
            // btnFiltrarPais
            // 
            this.btnFiltrarPais.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiltrarPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarPais.Location = new System.Drawing.Point(110, 277);
            this.btnFiltrarPais.Name = "btnFiltrarPais";
            this.btnFiltrarPais.Size = new System.Drawing.Size(140, 47);
            this.btnFiltrarPais.TabIndex = 8;
            this.btnFiltrarPais.Text = "Filtrar por pais";
            this.btnFiltrarPais.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(301, 277);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(140, 47);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // GUI1_menu
            // 
            this.BackgroundImage = global::App_CatalogoCD.RecursosGUI1.ws_Blur_2560x1600;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnFiltrarPais);
            this.Controls.Add(this.btnVolcarAxml);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAnadirAzar);
            this.Controls.Add(this.btnXmlLeer);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.v);
            this.Name = "GUI1_menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
