using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using WebApplication4.Models;

namespace datos
{
    public class sql
    {
        public void ejecuta(String sql, String tipo, List<parametros> parametros = null)
        {
            SqlConnection databaseConnection = new SqlConnection(conexion.instancia.cadenaconexion());
            SqlCommand commandDatabase = new SqlCommand(sql, databaseConnection);
            if (tipo.Equals("1"))
            {
                commandDatabase.CommandType = CommandType.StoredProcedure;
                foreach (var parametro in parametros)
                {
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = parametro.tipo;
                    param.Value = parametro.valor;
                    commandDatabase.Parameters.Add(param);
                }
            }
            else if (tipo.Equals("2"))
            {
                commandDatabase.CommandType = CommandType.Text;
            }
            databaseConnection.Open();
            commandDatabase.ExecuteNonQuery();
            databaseConnection.Close();
        }


        public List<ArrayList> Lista(String sql, String tipo, List<parametros> parametros = null)
        {
            List<ArrayList> coleccion = new List<ArrayList>();
            SqlConnection databaseConnection = new SqlConnection(conexion.instancia.cadenaconexion());
            SqlCommand commandDatabase = new SqlCommand(sql, databaseConnection);
            if (tipo.Equals("1"))
            {
                commandDatabase.CommandType = CommandType.StoredProcedure;
                foreach (var parametro in parametros)
                {
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = parametro.tipo;
                    param.Value = parametro.valor;
                    commandDatabase.Parameters.Add(param);
                }
            }
            else if (tipo.Equals("2"))
            {
                commandDatabase.CommandType = CommandType.Text;
            }
            SqlDataReader reader;
            databaseConnection.Open();
            reader = commandDatabase.ExecuteReader();
            while (reader.Read())
            {
                ArrayList lista = new ArrayList();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    lista.Add(reader.GetString(i).ToString());
                }
                coleccion.Add(lista);
            }
            databaseConnection.Close();
            return coleccion;
        }
    }
}
