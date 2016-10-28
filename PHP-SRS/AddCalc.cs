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
        public void InsertIntoTable(string firstname, string surname, string dateofbirth, double daysalive, double martiandaysalive, string dbtimestamp)
        {
            DBConnect db = new DBConnect();
            if (db.OpenConnection() == true)
            {
                var cmd = db.conn.CreateCommand();

                cmd.CommandText = "INSERT INTO calctable (firstname,surname,dateofbirth,daysalive,martiandaysalive,dbtimestamp) VALUES ('" + firstname + "', '" + surname + "', '" + dateofbirth + "'," + daysalive + "," + martiandaysalive +",'" + dbtimestamp + "')";

                cmd.ExecuteNonQuery();
            }
        }
    }
}
