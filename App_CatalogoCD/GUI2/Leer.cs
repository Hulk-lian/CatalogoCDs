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
        public Leer()
        {
            InitializeComponent();
        }

        public void LeerDVD(string text)
        {
            textBox1.Text = text;
            textBox1.Focus();
            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.Select(textBox1.Text.Length, 0);
        }

    }
}
