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
    public partial class IntroducirCod : Form
    {
        public IntroducirCod()
        {
            InitializeComponent();
        }
        Catalogo cat = new Catalogo();

        public int codigo()
        {
            return int.Parse(txbCod.Text);
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            cat.BorrarDVD(codigo().ToString());
            this.Close();
        }

        private void btnmod_Click(object sender, EventArgs e)
        {
            cat.AddEntrada(codigo().ToString());
            this.Close();
        }


    }
}
