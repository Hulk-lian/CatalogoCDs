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
    public partial class Leer : Form
    {
        Catalogo c = new Catalogo();

        public Leer()
        {
            InitializeComponent();
        }

        private void LeerDVD()
        {
            this.Show();
            c.LeerDVD();
            textBox1.Text = c.ToString();
        }

    }
}
