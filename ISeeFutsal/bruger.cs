using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ISeeFutsal
{
    public class bruger
    {
        public String _fornavn { get; set; }
        public String _efternavn { get; set; }
        public String _email { get; set; }
        public String _telefon { get; set; }
        public String _password { get; set; }
        public 

        bruger(String first, String last, String email, String phone, String pass)
        {
            _fornavn = first;
            _efternavn = last;
            _email = email;
            _telefon = phone;
            _password = pass;
        }


        

        
    }
}