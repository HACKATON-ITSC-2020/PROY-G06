using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Datos;


namespace Vitas_Stock.MainForms
{
    public partial class Articulos : Form
    {
        CN_Productos pro = new CN_Productos();

         CD_Productos objetoCD = new CD_Productos();

        DataTable tabla = new DataTable();
        public Articulos()
        {
            InitializeComponent();
        }

        private void Articulos_Load(object sender, EventArgs e)
        {

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            pro.InsertarArticulo(txtnombre.Text);
        }


    }
}
