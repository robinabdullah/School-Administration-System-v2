using System;
using System.Collections.Generic;
using System.Text;

using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

class DataAccessClass
{
    static string _ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Using soft\Downloads\Compressed\School Administration Project\School Administration Project\School Database.mdf;Integrated Security=True;Connect Timeout=30";
    static SqlConnection _Connection = null;
    public static SqlConnection Connection
    {
        get
        {
            if (_Connection == null)
            {
                _Connection = new SqlConnection(_ConnectionString);
                _Connection.Open();

                return _Connection;
            }
            else if (_Connection.State != System.Data.ConnectionState.Open)
            {
                _Connection.Open();

                return _Connection;
            }
            else
            {
                return _Connection;
            }
        }
    }

    public static DataSet GetDataSet(string sql)
    {
        SqlCommand cmd = new SqlCommand(sql, Connection);
        SqlDataAdapter adp = new SqlDataAdapter(cmd);

        DataSet ds = new DataSet();
        adp.Fill(ds);
        Connection.Close();

        return ds;
    }

    public static DataTable GetDataTable(string sql)
    {
        DataSet ds = GetDataSet(sql);

        if (ds.Tables.Count > 0)
            return ds.Tables[0];
        return null;
    }

    public static int ExecuteSQL(string sql)
    {
        SqlCommand cmd = new SqlCommand(sql, Connection);
        return cmd.ExecuteNonQuery();
    }

    public static int ExecuteSQL(string sql, SqlParameter p)
    {
        SqlCommand cmd = new SqlCommand(sql, Connection);
        cmd.Parameters.Add(p);
        return cmd.ExecuteNonQuery();

    }
}
