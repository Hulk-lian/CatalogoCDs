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
    public partial class Modd : Form
    {
        dvd registro;
        Catalogo c = new Catalogo();
        public Modd()
        {
            InitializeComponent();
        }

        private void btn_enviar_Click(object sender, EventArgs e)
        {
            try
            {
                registro.Titulo = textBox2.Text;
                registro.Artista = textBox3.Text;
                registro.Pais = textBox4.Text;
                registro.Compania = textBox5.Text;
                registro.Precio = decimal.Parse(textBox6.Text);
                registro.Anio = ushort.Parse(textBox7.Text);
                c.ActualizarDVD(registro);
                MessageBox.Show("Registro Actualizado Correctamente");
            }

            catch
            {
                MessageBox.Show("Error al actualizar el registro");
            }

            this.Close();
        }

        private void PedirCampos(dvd registro)
        {
            textBox2.Text = registro.Titulo;
            textBox3.Text = registro.Artista;
            textBox4.Text = registro.Pais;
            textBox5.Text = registro.Compania;
            textBox6.Text = registro.Precio.ToString();
            textBox7.Text = registro.Anio.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string codigo = textBox1.Text;

                registro = c.LeerDVD(codigo);

                if (registro != null)
                {
                    btn_enviar.Enabled = true;
                    textBox2.ReadOnly = false;
                    textBox3.ReadOnly = false;
                    textBox4.ReadOnly = false;
                    textBox5.ReadOnly = false;
                    textBox6.ReadOnly = false;
                    textBox7.ReadOnly = false;
                    PedirCampos(registro);
                }
            }

            catch
            {
                MessageBox.Show("El código no existe o es erróneo");
            }
            
        }

    }
}
