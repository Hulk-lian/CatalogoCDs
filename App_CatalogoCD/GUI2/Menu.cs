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
    public partial class Menu : Form
    {
        static Catalogo c;
        public Menu()
        {
            InitializeComponent();
            c = new Catalogo();
        }

        private void btn_leer_Click(object sender, EventArgs e)
        {
            Leer lee = new Leer();
            c.LeerDVD();
            lee.LeerDVD(c.ToString());
            lee.Show();
        }

        private void btn_leerXML_Click(object sender, EventArgs e)
        {
            Leer lee = new Leer();
            lee.LeerDVD(c.Xml);
            lee.Show();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            AddDel add = new AddDel('a');
            add.Show();
         
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            AddDel add = new AddDel('b');
            add.Show();
        }

        private void btn_modif_Click(object sender, EventArgs e)
        {
            Modd modif = new Modd();
            modif.Show();
        }

        private void btn_saveXML_Click(object sender, EventArgs e)
        {
            if(saveFile.ShowDialog() == DialogResult.OK)
                c.XmlAFichero(saveFile.FileName);
            
        }

        /// <summary>
        /// Evento del botón 'Salir'
        /// Sale del programa.
        /// </summary>
        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
