using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace App_CatalogoCD.GUI1
{
    public partial class GUI1 : Form
    {
        public GUI1()
        {
            InitializeComponent();
        }
        Catalogo cat = new Catalogo();
        private void btnLeer_Click(object sender, EventArgs e)
        {
            Lecturas lect = new Lecturas();
            cat.LeerDVD();
            lect.llenarTextBox(cat.ToString());
            lect.Show();

        }

        private void btnXmlLeer_Click(object sender, EventArgs e)
        {
            Lecturas lect = new Lecturas();
            lect.llenarTextBox(cat.Xml);
            lect.Show();
        }

        private void btnAnadirAzar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnMod_Click(object sender, EventArgs e)
        {

        }

        private void btnVolcarAxml_Click(object sender, EventArgs e)
        {

        }

        private void btnFiltrarPais_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }
    }
}
