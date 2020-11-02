using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data.SqlClient;
using System.Data;


namespace Vitas_Stock.clases
{
    class Lotes
    {
        CD_Productos objetoCD = new CD_Productos();

        public void mandarlote(string nombre, int cantidad, DateTime fecha_ingreso, DateTime fecha_venc, DateTime fecha_egreso)
        {
            objetoCD.CargarL(nombre, Convert.ToInt32(cantidad), fecha_ingreso, fecha_venc , fecha_egreso );

        }

    }
}
