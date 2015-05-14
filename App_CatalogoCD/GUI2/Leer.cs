using System.Windows.Forms;

namespace App_CatalogoCD
{
    public partial class Leer : Form
    {
        public Leer()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método que muestra por consola tanto la colección de DVD como la biblioteca XML de DVD
        /// Los parámetros son puramente estéticos
        /// </summary>
        /// <param name="text"></param>
        public void LeerDVD(string text)
        {
            textBox1.Text = text;
            textBox1.Focus();
            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.Select(textBox1.Text.Length, 0);
        }

    }
}
