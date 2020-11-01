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

        public DataTable MostrarP()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select  a.nombre , l.fecha_ingreso, l.cantidad, l.fecha_venc from Articulo a, Lotes l where a.id_articulo = l.cod_articulo";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

        
        public void InsertarA(string nombre )
        {
            comando.Connection = conexion.AbrirConexion();
            //MessageBox.Show("insert into Articulo(Nombre) values("+nombre+")");
            comando.CommandText = "insert into Articulo (Nombre) values ('"+nombre+"')";
            //comando.CommandType = CommandType.Text;
           comando.ExecuteNonQuery();

            conexion.CerrarConexion();

        }
        public void CargarL(int idlote, int cod, DateTime fi, int cant, DateTime fv)
        {


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
