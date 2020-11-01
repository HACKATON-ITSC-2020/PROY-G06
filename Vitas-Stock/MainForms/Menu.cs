﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Negocio;
using Vitas_Stock.MainForms;
using Datos;

//pruebazsczc
//nuevo comentario
namespace FE
{

    public partial class frmMenu : Form
    {
        DataTable tabla = new DataTable();

        CD_Productos objetoCD = new CD_Productos();
        CN_Productos pro = new CN_Productos();
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
            //dataGridView1.DataSource = pro.MostrarProd();

            tabla = objetoCD.MostrarCB();
            cbProductos.DataSource = tabla;
            cbProductos.DisplayMember = "Nombre";
            cbProductos.ValueMember = "id_articulo";
           

            //
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
          //  pro.InsertarArticulo(txtnombre.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Articulos frm = new Articulos();

            frm.Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbProductos_SelectedValueChanged(object sender, EventArgs e)
        {
           // MessageBox.Show(cbProductos.SelectedValue.ToString());
        }
    }
}
