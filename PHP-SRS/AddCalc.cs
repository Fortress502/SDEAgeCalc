using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Npgsql;

namespace AgeCalc
{
    class AddCalc
    {
        public void InsertIntoTable(string name, string dateOfBirth, double daysAlive, string dbtimestamp)
        {
            DBConnect db = new DBConnect();
            if (db.OpenConnection() == true)
            {
                var cmd = db.conn.CreateCommand();

                cmd.CommandText = "INSERT INTO calctable (name,dateofbirth,daysalive,dbtimestamp) VALUES ('" + name + "', '" + @dateOfBirth + "'," + daysAlive + ",'" + dbtimestamp + "')";

                cmd.ExecuteNonQuery();
            }
        }
    }
}
