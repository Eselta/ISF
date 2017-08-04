using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace ISeeFutsal
{
    public partial class Login2 : System.Web.UI.Page
    {
        loginCheck lc = new loginCheck();
        OverallLogin l = OverallLogin.Instance;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void login_Click(object sender, EventArgs e)
        {
            String user = username.Value;
            String pass = password.Value;

            if (lc.login(user, pass))
            {
                l.username = lc.getNameFromDB(user);
                l.login = true;
                Response.Redirect("MainPage.aspx");
            }
        }
    }

    public class loginCheck
    {
        MasterDB db = MasterDB.Instance;
        MySqlConnection conn;
        String checkedUsername;

        private Boolean checkLogin(String email)
        {
            Boolean valid = false;

            conn = db.conOpen();

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT EXISTS(SELECT 1 FROM logincheck WHERE username = @email)";
            cmd.Prepare();

            cmd.Parameters.AddWithValue("@email", email);
            MySqlDataReader reader = cmd.ExecuteReader();

            if(reader != null)
            {
                valid = true;
            }
            reader.Close();

            return valid;
        }

        public Boolean login(String user, String pass)
        {
            Boolean loggedIn = false;

            checkedUsername = user;
            String pWord = pass;

            String toCheck = null;

            if(checkLogin(checkedUsername))
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT password FROM logincheck WHERE username = @email";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@email", user);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    toCheck = reader[0].ToString();
                }

                if(pass.Equals(toCheck))
                {
                    loggedIn = true;
                }
                reader.Close();
            }
            

            return loggedIn;
        }

        public String getNameFromDB(String email)
        {
            String name = null;

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT firstname FROM user WHERE email = @email";
            cmd.Prepare();

            cmd.Parameters.AddWithValue("@email", email);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                name = reader[0].ToString();
            }

            reader.Close();

            return name;
        }
    }
}