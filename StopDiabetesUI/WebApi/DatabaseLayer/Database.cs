using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using StopDiabetesDB;


namespace WebApi.DatabaseLayer
{
    public class Database
    {
        SqlConnection conn = new SqlConnection(@"data source=.\SQLEXPRESS;initial catalog=StopDiabetes;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");
        public DataSet GetLaporan()
        {
            SqlCommand comm = new SqlCommand("SPGetKritik", conn);
            comm.CommandType = CommandType.StoredProcedure;
            //comm.Parameters.AddWithValue("@Id", id);
            SqlDataAdapter da = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;

        }
    }
    
}