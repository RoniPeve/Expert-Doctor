using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Conexion
{
    public class Utilidades
    {
        public static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);

        
        public static DataSet Ejecutar(string cmd)
        {
            con.Open();
            DataSet DS = new DataSet();
            SqlDataAdapter DP = new SqlDataAdapter(cmd, con);
            DP.Fill(DS);
            con.Close();
            return DS;
        }
        public static DataSet llenarDatosTabla(string tabla)
        {

            string cmd = String.Format("select*from " + tabla);
            DataSet ds = Ejecutar(cmd);
            return ds;
        }
        public static DataSet llenarDatosConsulta(string campo, string tabla)
        {
            string cmd = "select " + campo + " from "+tabla;
            DataSet ds = Ejecutar(cmd);
            return ds;
        }

    }
}
