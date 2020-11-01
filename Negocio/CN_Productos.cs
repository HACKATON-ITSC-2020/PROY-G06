using System;
using System.Collections.Generic;
using System.Text;
using Datos;
using System.Data;
using System.Windows.Forms;

namespace Negocio
{
  public  class CN_Productos
    {
        
        private CD_Productos objetoCD = new CD_Productos();
        public DataTable MostrarProd()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
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
