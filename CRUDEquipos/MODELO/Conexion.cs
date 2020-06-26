using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CRUDEquipos.MODELO
{
    public class Conexion
    {
        public SqlConnection con;
        public SqlCommand cmd;
        public SqlDataReader dr;

        public Conexion()
        {
            con = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=fnstore;Integrated Security=True");
        }
    }
}