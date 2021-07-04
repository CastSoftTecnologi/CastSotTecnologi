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
        public static string ImdMesa = "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";


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
        public bool IsNumeric(string numero) {
            double Num;
            try
            {
                Num = double.Parse(numero);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        
        }
    }
}
