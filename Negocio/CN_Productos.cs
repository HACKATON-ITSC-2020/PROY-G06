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


  
        public DataTable MostarProductos()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }
       


    }
}
