using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MySql.Data.MySqlClient;

namespace AgeCalc
{
    class AddCalc
    {
        public void InsertIntoTable(string name, string dateOfBirth, double daysAlive, DateTime timestamp)
        {
            DBConnect db = new DBConnect();
            if (db.OpenConnection() == true)
            {
                var cmd = db.conn.CreateCommand();

                cmd.CommandText = "INSERT INTO calctable(name,dateOfBirth,daysAlive,timestamp) VALUES(@name, @dateOfBirth,@daysAlive,@timestamp)";

                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@dateOfBirth", dateOfBirth);
                cmd.Parameters.AddWithValue("@daysAlive", daysAlive);
                cmd.Parameters.AddWithValue("@timestamp", timestamp); 
                cmd.ExecuteNonQuery();
            }
        }
    }
}
