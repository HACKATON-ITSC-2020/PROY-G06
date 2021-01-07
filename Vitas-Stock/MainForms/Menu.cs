using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Vitas_Stock.MainForms;
using Datos;
using Vitas_Stock.clases;

//pruebazsczc
//nuevo comentario
namespace FE
{

    public partial class frmMenu : Form
    {
        DataTable tabla = new DataTable();

        CD_Productos objetoCD = new CD_Productos();
       Lotes objLote = new Lotes();
        public frmMenu()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        #region arrastrarForm
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void lblTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            //botones y texboox desabilitados
            cbProductos.Enabled = false;
            txtCantidad.Enabled = false;
            dtpIngreso.Enabled = false;
            dtpvenci.Enabled = false;
            btnCargar.Enabled = false;
            btnDespachar.Enabled = false;
               
            
            //dataGridView1.DataSource = pro.MostrarProd();

            tabla = objetoCD.MostrarCB();
            cbProductos.DataSource = tabla;
            cbProductos.DisplayMember = "Nombre";
            cbProductos.ValueMember = "id_articulo";
            
            dataGridView1.DataSource = objetoCD.Mostrar();


            //
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
        
            //cod_articulo, fecha_ingreso, cantidad, fecha_venc,
            objetoCD.CargarL(Convert.ToInt32(cbProductos.SelectedValue.ToString()), Convert.ToInt32(txtCantidad.Text), dtpIngreso.Text, dtpvenci.Text);
            dataGridView1.DataSource = objetoCD.Mostrar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Articulos frm = new Articulos();

            frm.ShowDialog();

            tabla = objetoCD.MostrarCB();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbProductos_SelectedValueChanged(object sender, EventArgs e)
        {
           // MessageBox.Show(cbProductos.SelectedValue.ToString());
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
      


        }

        private void btnDespachar_Click(object sender, EventArgs e)
        {
            int descontar = Convert.ToInt32(objetoCD.funcDesc(Convert.ToInt32(cbProductos.SelectedValue.ToString())))- Convert.ToInt32(txtCantidad.Text);
            objetoCD.Despachar(descontar, Convert.ToInt32(cbProductos.SelectedValue.ToString()));
            dataGridView1.DataSource = objetoCD.Mostrar();
        }

        private void cbProductos_TextUpdate(object sender, EventArgs e)
        {
            //habilitacion de texto
            if (cbProductos.Text != "")
            {
                txtCantidad.Enabled = true;
            }
            else
            {
                txtCantidad.Enabled = false;
            }
        }

        private void txtCantidad_VisibleChanged(object sender, EventArgs e)
        {
            //habilitacion de fechas y boton
            if (txtCantidad.Text != "")
            {
                dtpIngreso.Enabled = true;
                dtpvenci.Enabled = true;
                btnCargar.Enabled = true;
            }
            else
            {
                dtpIngreso.Enabled = false;
                dtpvenci.Enabled = false;
                btnCargar.Enabled = false;
            }
        }

        
    }
}
