using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CapaBD
{
    public class ConexionBD
    {

        public SqlConnection cn;
        public SqlCommand cmd;  
        public SqlDataReader rd;
        public string mensaje = "";

        //ejecutar la conexion a la base de datos
        public ConexionBD()
        {
            try
            {
                cn = new SqlConnection("Data Source=PCMASTERRACE\\SQLEXPRESS;Initial Catalog=WIMAX_FERIA_01;Integrated Security=true;");
                mensaje = "Conexión exitosa";
            }
            catch (Exception ex)
            {
                mensaje = "Error, conexión fallida: " + ex.Message;


            }


        }

    }
}
