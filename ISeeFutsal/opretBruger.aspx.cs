using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace ISeeFutsal
{
    public partial class opretBruger : System.Web.UI.Page
    {
        brugerDB db = new brugerDB();

        protected void Page_Load(object sender, EventArgs e)
        {
            brugerDB db = new brugerDB();
        }

        protected void opretBtn_Click(object sender, EventArgs e)
        { 
            bruger b = new bruger(firstname.Value, lastname.Value, email.Value, phone.Value, password.Value);

            

            db.insertUser(b._fornavn, b._efternavn, b._email, b._telefon);
            db.insertLogin(b._email, b._password);
            Response.Redirect("oprettetDone.aspx");
        }
    }

    public class brugerDB
    {
        MasterDB db = MasterDB.Instance;
        MySqlConnection conn;


        public void insertUser(String first, String last, String email, String phone)
        {

            try
            {
                conn = db.conOpen();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO user VALUES(@firstname, @lastname, @email, @phone)";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@firstname", first);
                cmd.Parameters.AddWithValue("@lastname", last);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.ExecuteNonQuery();

            }
            catch (MySqlException ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());

            }
            finally
            {
                db.conClose();
            }
        }

        public void insertLogin(String username, String password)
        {
            try
            {
                conn = db.conOpen();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO login VALUES(@username, @password)";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.ExecuteNonQuery();
            }

            catch (MySqlException e)
            {
                System.Diagnostics.Debug.WriteLine("Error: {0} ", e.ToString());
            }
            finally
            {
                db.conClose();
            }
        }
    }
}