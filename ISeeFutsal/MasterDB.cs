using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ISeeFutsal
{
    public class MasterDB
    {
        MySqlConnection conn;
        String constring = "server=localhost;database=sesso;uid=root;pwd=rootbeer;";

        private static MasterDB instance;

        private MasterDB() { }

        public static MasterDB Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MasterDB();
                }
                return instance;
            }
        }

        public void conClose()
        {
            if(conn != null)
            {
                conn.Close();
            }
        }

        public MySqlConnection conOpen()
        {
            conn = new MySqlConnection(constring);

            try
            {
                conn.Open();
            }

            catch(MySqlException e)
            {
                Console.WriteLine("Error: {0}", e.ToString());
            }

            return conn;
        }

        public String getConString()
        {
            return constring;
        }
    }
}