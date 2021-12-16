using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPPemrog.Model
{
    class LoginModel
    {
        public string email;
        public string password;

        public bool checklogin()
        {
            bool result;
            if (email == "tono@ymail.com" && password == "12345")
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }
    }
}
