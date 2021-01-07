using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

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
            DataTable tabla3 = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select  a.nombre , l.fecha_ingreso, l.cantidad, l.fecha_venc from Articulo a, Lotes l where a.id_articulo = l.cod_articulo";
            leer = comando.ExecuteReader();
            tabla3.Load(leer);
            conexion.CerrarConexion();
            return tabla3;

        }

        public DataTable MostrarCB()
        {
            DataTable tabla4 = new DataTable();
            try
            {
                

                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "select * from Articulo";
                leer = comando.ExecuteReader();
                tabla4.Load(leer);
                //while (leer.Read())
                //{
                //    cb.Items.Add(leer["Nombre"].ToString());
                //}
                //leer.Close();

            }

            catch (Exception)
            {
                MessageBox.Show("Test");
            }
            return tabla4;
        }


        public void InsertarA(string nombre )
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into Articulo values ('"+nombre+"')";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();

            conexion.CerrarConexion();

        }
        public void CargarL(int cod_art ,int cantidad, string fecha_ingreso, string fecha_venc)
        {
            comando.Connection = conexion.AbrirConexion();
            //comando.CommandText = "insert into Lotes values( " + cantidad + ", " + fecha_ingreso + ", " + fecha_venc + ",  "+fecha_egreso+" )";
            comando.CommandText = String.Format("insert into Lotes (cod_articulo, cantidad, fecha_ingreso, fecha_venc) values({0},{1},'{2}','{3}')", cod_art,cantidad,fecha_ingreso,fecha_venc);
            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }


        public void Despachar(int cantidad, int cod_articulo)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = String.Format("update Lotes set cantidad = {0}  where fecha_venc in (select  min (fecha_venc) from Lotes where cod_articulo = {1} )  and cod_articulo = {1} ", cantidad,cod_articulo);
            comando.ExecuteNonQuery();

            conexion.CerrarConexion();
        }

        public string funcDesc(int cod_art)
        {
            DataTable tabla2 = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = String.Format("select top 1 cantidad from Lotes where cod_articulo = {0} order by fecha_venc", cod_art);
            //comando.ExecuteNonQuery() ;
           var cantidad = comando.ExecuteScalar();
           

            return cantidad.ToString() ;

        }


    }
}
