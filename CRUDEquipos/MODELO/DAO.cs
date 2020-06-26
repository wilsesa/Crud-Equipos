using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace CRUDEquipos.MODELO
{
    public class DAO
    {
        private Conexion c;

        public DAO()
        {
            c = new Conexion();
        }

        /*CRUD*/

            /*Insert*/
        public void crearEquipo(Equipo e)
        {
            String insert = "INSERT INTO equipo VALUES('" + e.id + "','" + e.nombre + "','" + e.estado + "')";

            ejecutar(insert);
            //c.con.Open();
            //c.cmd = new SqlCommand(insert, c.con);
            //c.cmd.ExecuteNonQuery();
            //c.con.Close();

        }

        /*Select*/
        public Equipo buscarEquipoPorId(String id)
        {
            Equipo e = null;

            String select = "SELECT * FROM equipo WHERE id = '"+id+"'";
            c.con.Open();
            c.cmd = new SqlCommand(select, c.con);
            c.dr = c.cmd.ExecuteReader();
            if (c.dr.Read())
            {
                e = new Equipo();

                //e.id =  c.dr.GetString(0);
                e.nombre = c.dr.GetString(1);
                e.estado = c.dr.GetString(2);
            }
            c.con.Close();
            return e;

        }

        /*Updata*/
        public void actualizarEquipo(Equipo e)
        {
            string update = "UPDATE equipo SET nombre = '"+e.nombre+"', estado = '"+e.estado+"' WHERE id = '"+e.id+"'";
            ejecutar(update);
        }

        /*Delete*/
        public void excluirEquipo(int id)
        {
            String delete = "DELETE FROM equipo WHERE id = '" + id + "'";
            ejecutar(delete);
        }

        public void ejecutar(String consultaSQL)
        {
            c.con.Open();
            c.cmd = new SqlCommand(consultaSQL, c.con);
            c.cmd.ExecuteNonQuery();
            c.con.Close();
        }

        
    }
}