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
    public partial class Modificaciones : Form
    {
        public Modificaciones()
        {
            InitializeComponent();
        }

        private void nudcodigos_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void Modificaciones_Load(object sender, EventArgs e)
        {
            Catalogo cata= new Catalogo();
            foreach (dvd item in cata.CatalogoDVD)
            {
                cmbcodigos.Items.Add(item.Codigo);
            }
        }
    }
}
