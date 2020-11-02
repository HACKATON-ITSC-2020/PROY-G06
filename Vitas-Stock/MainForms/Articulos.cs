using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;


namespace Vitas_Stock.MainForms
{
    public partial class Articulos : Form
    {

         CD_Productos objetoCD = new CD_Productos();

        DataTable tabla = new DataTable();
        public Articulos()
        {
            InitializeComponent();
        }

        private void Articulos_Load(object sender, EventArgs e)
        {
            btnagregar.Enabled = false;
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            InsertarArticulo(txtnombre.Text);
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
            if (txtnombre.Text != "")
            {
                btnagregar.Enabled = true;
            }
            else
            {
                btnagregar.Enabled = false;
            }
        }

        public void InsertarArticulo(string nombre)
        {


            try
            {
                objetoCD.InsertarA(nombre);

                MessageBox.Show("se inserto correctamente");

            }
            catch (Exception ex)
            {
                MessageBox.Show("no se pude insertar los datos por : " + ex);

            }


        }
    }
}
