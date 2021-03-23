using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SisFact
{
    public class Acceso
    {
        public SqlConnection conexion = new SqlConnection("data source = " + Dns.GetHostName() + @"\SQLEXPRESS; initial catalog = CastDb; user id = sa; password = hiper574dark*");
        public DataSet ds = new DataSet();
        public SqlDataAdapter da;
        public SqlDataReader dr;
        public SqlCommand comando;

        public static string x_usuario;
        public static int c_usuario;


        public void Lectura(string sql)
        {
            conexion.Open();
            comando = new SqlCommand(sql, conexion);
            dr = comando.ExecuteReader();
        }
        public void Consulta(string sql, string tabla)
        {
            ds.Tables.Clear();
            da = new SqlDataAdapter(sql, conexion);
            da.Fill(ds, tabla);
        }
        public void Ejecuta(string sql)
        {
            conexion.Open();
            comando = new SqlCommand(sql, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }
        public bool Ejecutar(string sql)
        {
            conexion.Open();
            comando = new SqlCommand(sql, conexion);
            dr = comando.ExecuteReader();
            if (dr.Read())
            {
                conexion.Close();
                return true;
            }
            else
            {
                conexion.Close();
                return false;
            }
        }
    }
}
