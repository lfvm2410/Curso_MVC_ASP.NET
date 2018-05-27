using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

public class DALClientes
{

    public Boolean InsertarCliente(EntidadClientes cliente)
    {
        Conectividad aux = new Conectividad();

        SqlCommand cmd = new SqlCommand();
        cmd.Connection = aux.conectar(); //abre conexion
        cmd.Parameters.Add(new SqlParameter("@_ClienteID", cliente.ClienteID));
        cmd.Parameters.Add(new SqlParameter("@_Nombre", cliente.Nombre));
        cmd.Parameters.Add(new SqlParameter("@_Apellidos", cliente.Apellidos));
        cmd.Parameters.Add(new SqlParameter("@_Direccion", cliente.Direccion));
        cmd.Parameters.Add(new SqlParameter("@_Telefono", cliente.Telefono));
        cmd.Parameters.Add(new SqlParameter("@_Email", cliente.Email));
        cmd.Parameters.Add(new SqlParameter("@_Fecha_Ingreso", cliente.Fecha_Ingreso));
        cmd.Parameters.Add(new SqlParameter("@_Sexo", cliente.Sexo));
        cmd.Parameters.Add(new SqlParameter("@_TipoClienteID", cliente.TipoClienteID));
        cmd.Parameters.Add(new SqlParameter("@_Clave", "$5jdk8"));
        cmd.CommandText = "InsertarCliente";
        cmd.CommandType = CommandType.StoredProcedure;
        int x = cmd.ExecuteNonQuery();
        aux.conectar(); // cierra conexion
        if(x >= 1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void ActualizarCliente(EntidadClientes cliente)
    {
        Conectividad aux = new Conectividad();

        SqlCommand cmd = new SqlCommand();
        cmd.Connection = aux.conectar(); //abre conexion
        cmd.Parameters.Add(new SqlParameter("@_ClienteID", cliente.ClienteID));
        cmd.Parameters.Add(new SqlParameter("@_Nombre", cliente.Nombre));
        cmd.Parameters.Add(new SqlParameter("@_Apellidos", cliente.Apellidos));
        cmd.Parameters.Add(new SqlParameter("@_Direccion", cliente.Direccion));
        cmd.Parameters.Add(new SqlParameter("@_Telefono", cliente.Telefono));
        cmd.Parameters.Add(new SqlParameter("@_Email", cliente.Email));
        cmd.Parameters.Add(new SqlParameter("@_Fecha_Ingreso", cliente.Fecha_Ingreso));
        cmd.Parameters.Add(new SqlParameter("@_Sexo", cliente.Sexo));
        cmd.Parameters.Add(new SqlParameter("@_TipoClienteID", cliente.TipoClienteID));
        cmd.Parameters.Add(new SqlParameter("@_Clave", "$5jdk8"));
        cmd.CommandText = "ActualizarCliente";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.ExecuteNonQuery();
        aux.conectar(); // cierra conexion
    }

    public Boolean EliminarCliente(string id)
    {
        Conectividad aux = new Conectividad();

        SqlCommand cmd = new SqlCommand();
        cmd.Connection = aux.conectar();
        cmd.Parameters.Add(new SqlParameter("@_ClienteID", id));
        cmd.CommandText = "EliminarCliente";
        cmd.CommandType = CommandType.StoredProcedure;
        int x = cmd.ExecuteNonQuery();
        aux.conectar(); // cierra conexion
        if (x >= 1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public EntidadClientes BuscarCliente(string ClienteID)
    {
        EntidadClientes cliente = new EntidadClientes();
        Conectividad aux = new Conectividad();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = aux.conectar();
        cmd.Parameters.Add(new SqlParameter("@_ClienteID", ClienteID));
        cmd.CommandText = "BuscarCliente";
        cmd.CommandType = CommandType.StoredProcedure;
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            cliente.ClienteID = dr["ClienteID"].ToString();
            cliente.Nombre = dr["Nombre"].ToString();
            cliente.Apellidos = dr["Apellidos"].ToString();
            cliente.Direccion = dr["Direccion"].ToString();
            cliente.Telefono = dr["Telefono"].ToString();
            cliente.Email = dr["Email"].ToString();
            cliente.Fecha_Ingreso = Convert.ToDateTime(dr["Fecha"].ToString());
            cliente.TipoClienteID = dr["TipoClienteID"].ToString();
            cliente.Sexo = dr["Sexo"].ToString();
            cliente.Clave = dr["Clave"].ToString();
        }
        else
        {
            cliente = null;
        }
        aux.conectar();
        return cliente;
    }

    public List<EntidadClientes> ListarClientes()
    {
        Conectividad aux = new Conectividad();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = aux.conectar();
        cmd.CommandText = "ListarClientes";
        cmd.CommandType = CommandType.StoredProcedure;
        SqlDataReader dr = cmd.ExecuteReader();
        List<EntidadClientes> lista = new List<EntidadClientes>();

        while (dr.Read())
        {
            EntidadClientes cliente = new EntidadClientes();
            cliente.ClienteID = dr["ClienteID"].ToString();
            cliente.Nombre = dr["Nombre"].ToString();
            cliente.Apellidos = dr["Apellidos"].ToString();
            cliente.Direccion = dr["Direccion"].ToString();
            cliente.Telefono = dr["Telefono"].ToString();
            cliente.Email = dr["Email"].ToString();
            cliente.Fecha_Ingreso = Convert.ToDateTime(dr["Fecha"].ToString());
            cliente.TipoClienteID = dr["TipoClienteID"].ToString();
            cliente.Sexo = dr["Sexo"].ToString();
            cliente.Clave = dr["Clave"].ToString();
            lista.Add(cliente);
        }
        aux.conectar();
        return lista;
    }
}