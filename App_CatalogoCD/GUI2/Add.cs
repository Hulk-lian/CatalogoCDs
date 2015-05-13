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
    public partial class Add : Form
    {

        public Add()
        {
            InitializeComponent();
        }

        private void btn_enviar_Click(object sender, EventArgs e)
        {
            Catalogo c = new Catalogo();
            c.AddEntrada(textBox1.Text);
        }
    }
}
