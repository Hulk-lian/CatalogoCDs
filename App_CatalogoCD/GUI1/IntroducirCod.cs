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

        private void btncont_Click(object sender, EventArgs e)
        {
            codigo();
            this.Close();
        }
        public int codigo()
        {
            return int.Parse(txbCod.Text);
        }
    }
}
