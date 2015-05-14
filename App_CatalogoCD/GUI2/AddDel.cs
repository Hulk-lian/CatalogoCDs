using System;
using System.Windows.Forms;

namespace App_CatalogoCD
{
    public partial class AddDel : Form
    {
        char variable;

        /// <summary>
        /// Constructor Modificado con una variable tipo char.
        /// Este parámetro me permite reutilizar si actualizar el formulario para pedir el codigo para crear al azar, o para borrar.
        /// </summary>
        /// <param name="tipo">Char. Si se le pasa una 'a' llama al método add() si no llama al metodo borrar()</param>
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

        /// <summary>
        /// Acciones del botón. Controla la variable para saber a que método llamar y poder reutilizar el form con dos métodos distintos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (variable == 'a')               
                add();

            else          
                borrar();
                
        }

        /// <summary>
        /// Método que permite añadir un DVD con datos al azar con un código de nuestra elección.
        /// Excepciones Controladas
        /// </summary>
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

        /// <summary>
        /// Método que permite borrar un DVD eligiendo el código del DvD.
        /// Excepciones Controladas
        /// </summary>
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
