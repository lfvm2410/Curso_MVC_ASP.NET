using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

public class Conectividad
{

    public SqlConnection conectar()
    {
        string strConn;

        try
        {
            //Direccionamiento dinamico, obteniendo el nombre de la conexion desde el Web.config
            strConn = ConfigurationManager.ConnectionStrings["dbConn"].ConnectionString.ToString();
        }catch(Exception ex)
        {
            //Direccionamiento manual
            strConn = "Data Source=LUIS-PC\\SQLSERVERLUIS;Initial Catalog=dbbancos;Integrated Security=True";
        }

        SqlConnection conn = new SqlConnection(strConn);

        try
        {
            if (conn.State.Equals(ConnectionState.Closed))
            {
                conn.Open();
            }
            else
            {
                conn.Close();
            }

        }catch(Exception ex)
        {
        }

        return conn;
    }

}