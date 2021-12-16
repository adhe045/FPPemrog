using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPPemrog.Controller
{
    class LoginController
    {
        //declare object utk class model dan view
        Model.LoginModel model; // object class model(login)
        View.LoginWindow view; // object class view (LoginWindow)

        //varibale untuk pesan
        public string pesan;

        //instance -> constructor
        public LoginController(View.LoginWindow view)
        {
            model = new Model.LoginModel();
            this.view = view;
        }
        //request dan respon -> function biasanya void
        public void ValidasiLogin()
        {
            //data -> diambil dari view (input)
            model.email = view.txtEmail.Text;
            model.password = view.txtPassword.Password;
            //result dari model (true/false)
            bool hasil = model.checklogin();
            //response -> view
            if (hasil)
            {
                pesan = "";
                View.HomeWindow home = new View.HomeWindow();
                home.Show();
                view.Close();
            }
            else
            {
                pesan = "Email/Password salah!";
                view.txtEmail.Text = "";
                view.txtPassword.Password = "";
                view.txtEmail.Focus();
            }
        }
    }
}
