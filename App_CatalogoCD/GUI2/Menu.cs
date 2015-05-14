using System;
using System.Windows.Forms;

namespace App_CatalogoCD
{
    public partial class Menu : Form
    {
        static Catalogo c;

        /// <summary>
        /// Constructor del menú principal. Instancia la clase catálogo para poder llamar a los cambios.
        /// </summary>
        public Menu()
        {
            InitializeComponent();
            c = new Catalogo();
        }

        /// <summary>
        /// Acciones del botón Leer.
        /// Abre un nuevo diálogo mostrando todos los DVD's
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_leer_Click(object sender, EventArgs e)
        {
            Leer lee = new Leer();
            c.LeerDVD();
            lee.LeerDVD(c.ToString());
            lee.Show();
        }

        /// <summary>
        /// Acciones del botón 'Leer XML'
        /// Abre un nuevo diálogo mostrando todos los DVD's en formato XML
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_leerXML_Click(object sender, EventArgs e)
        {
            Leer lee = new Leer();
            lee.LeerDVD(c.Xml);
            lee.Show();
        }

        /// <summary>
        /// Acciones del botón Añadir un DVD con datos al azar
        /// Llama al formulario AddDel con el parámetro 'a' para que se ejecute el método Añadir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_add_Click(object sender, EventArgs e)
        {
            AddDel add = new AddDel('a');
            add.Show();
         
        }

        /// <summary>
        /// Acciones del botón Borrar un DVD
        /// Llama al formulario AddDel con el parámetro 'b' para que se ejecute el método Borrar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_delete_Click(object sender, EventArgs e)
        {
            AddDel add = new AddDel('b');
            add.Show();
        }

        /// <summary>
        /// Acciones del método Modificar un DVD
        /// Instancia y llama al método Modificar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_modif_Click(object sender, EventArgs e)
        {
            Modd modif = new Modd();
            modif.Show();
        }

        /// <summary>
        /// Acciones del botón 'Guardar Archivo XML'
        /// Llama a un diálogo de guardado, y guarda el fichero en la ubicación y con el nombre que deseemos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_saveXML_Click(object sender, EventArgs e)
        {
            if(saveFile.ShowDialog() == DialogResult.OK)
                c.XmlAFichero(saveFile.FileName);
            
        }

        /// <summary>
        /// Evento del botón 'Salir'
        /// Sale del programa.
        /// Está comentado para que no funcione y corregir el bug en un hotfix
        /// </summary>
        private void btn_salir_Click(object sender, EventArgs e)
        {
            //Application.Exit();
        }
    }
}
