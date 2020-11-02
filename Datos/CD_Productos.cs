using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class CD_Productos
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        public DataTable Mostrar()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select  a.nombre , l.fecha_ingreso, l.cantidad, l.fecha_venc from Articulo a, Lotes l where a.id_articulo = l.cod_articulo";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

        public DataTable MostrarCB()
        {

            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "select * from Articulo";
                leer = comando.ExecuteReader();
                tabla.Load(leer);
                //while (leer.Read())
                //{
                //    cb.Items.Add(leer["Nombre"].ToString());
                //}
                //leer.Close();

            }

            catch (Exception ex)
            {

            }
            return tabla;
        }


        public void InsertarA(string nombre )
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into Articulo values ("+nombre+")";
            comando.CommandType = CommandType.Text;
           // comando.ExecuteNonQuery();

            conexion.CerrarConexion();

        }
        public void CargarL(string nombre, int cantidad, DateTime fecha_ingreso, int fecha_venc, DateTime fecha_egreso)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into Lotesvalues('"+nombre+ "', " + cantidad + ", " + fecha_ingreso + ", " + fecha_venc + ", " + fecha_egreso + " )";


        }


        public void Despachar(string nombre)
        {

        }
        public void Insertar(string nombre)
        {

   

        }
        public void Editar(string nombre)
        {
            
        }
        public void Eliminar(int id)
        {
     
        }

    }
}
