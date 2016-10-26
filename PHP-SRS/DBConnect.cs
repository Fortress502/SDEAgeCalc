using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace AgeCalc
{
    public class DBConnect
    {
        public NpgsqlConnection conn;
        public string connString;

        //Constructor
        public DBConnect()
        {
            Initialize();
        }

        public void Initialize()
        {
            string connString = "Host=localhost;port=5432;username=SDE;Password=SDEAgeCalc;database=agecalc;";
            conn = new NpgsqlConnection(connString);
        }


        //Open Connection
        public bool OpenConnection()
        {
            try
            {
                conn.Open();
                return true;
            }
            catch (NpgsqlException ex)
            {
                return false;
            }
        }

        public bool CloseConnection()
        {
            try
            {
                conn.Close();
                return true;
            }
            catch (NpgsqlException ex)
            {
                return false;
            }
        }


    }
}