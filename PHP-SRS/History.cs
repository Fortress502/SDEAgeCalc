﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace AgeCalc
{
    class History
    {
        public void SelectFromTable(string selectQuery, DataGridView dataGridStock)
        {
            string query = selectQuery; //Acquires the SQL SELECT statement from the reference
            DBConnect db = new DBConnect();

            try
            {
                if (db.OpenConnection() == true)
                {

                    DataSet ds = new DataSet();

                    var npgsqlDA = new NpgsqlDataAdapter(selectQuery, db.conn);
                    npgsqlDA.Fill(ds);
                    dataGridStock.DataSource = ds.Tables[0].DefaultView;
                }
            }
            catch
            {
                throw;
            }
        }
        }
    }

