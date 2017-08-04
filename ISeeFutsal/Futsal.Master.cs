using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ISeeFutsal
{
    public partial class Futsal : System.Web.UI.MasterPage
    {
        OverallLogin l = OverallLogin.Instance;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (l.login)
            {
                log.Visible = false;
                loginName.Text = "Hello, "+l.username;
                loginName.Visible = true;
            }
        }
    }

    public class OverallLogin
    {
        public Boolean login { get; set; }
        public String username { get; set; }

        private static OverallLogin instance;

        private OverallLogin() { }

        public static OverallLogin Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new OverallLogin();
                }
                return instance;
            }
        }
    }

    public enum typeOfUser
    {
        Admin,
        Træner,
        Spiller
    }
}