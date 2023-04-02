using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.IO;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace Capa_datos.Conexion
{
    public class conexionDB
    {
        private SqlConnection c = new SqlConnection("Data Source=.;Initial Catalog=capadedatos;Integrated Security=True");

        public SqlConnection OpenConnection()
        { if (c.State == ConnectionState.Closed) c.Open();
        return c;
        
        }
        public SqlConnection CloseConnection()
        {
            if (c.State == ConnectionState.Open) c.Close();
            return c;

        }

    }

  
                
            
    
}