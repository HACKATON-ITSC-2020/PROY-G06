using System;
using System.Collections.Generic;
using System.Text;
using Datos;
using System.Data;


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

    }
}
