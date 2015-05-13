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
    public partial class AddDel : Form
    {
        char variable;
        public AddDel(char tipo)
        {
            InitializeComponent();
            variable = tipo;

            if (variable == 'a')
            {
                label1.Text = "Añadir un DVD";
                button1.Text = "Añadir";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (variable == 'a')               
                add();

                

            else          
                borrar();
                
        }

        private void add()
        {
            Catalogo c = new Catalogo();

            try
            {
                c.AddEntrada(textBox1.Text);
                MessageBox.Show("La insercción se ha implementado con éxito");
                this.Close();
            }

            catch
            {
                MessageBox.Show("La insersección ha fallado");
            }    
        }

        private void borrar()
        {
            Catalogo c = new Catalogo();

            try
            {
                c.BorrarDVD(textBox1.Text);
                MessageBox.Show("El borrado ha finalizado con éxito");
                this.Close();
            }

            catch
            {
                MessageBox.Show("El borrado ha fallado. Compruebe que es un código existente");
            }    
        }


    }
}
