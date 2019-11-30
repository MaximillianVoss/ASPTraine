using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPTraine.Pages
{
    public interface ICheck
    {
        public string Check(string login, string password);
    }
    public class Checker1 : ICheck
    {
        public string Check(string login, string password)
        {
            if (login == "adim" && password == "admin")
                return "success";
            return "login failed";
        }
    }
    public class Checker2 : ICheck
    {
        public string Check(string login, string password)
        {
            if (login == "user" && password == "12345678")
                return "success";
            return "login failed";
        }
    }
    public partial class Login : System.Web.UI.Page
    {
        int counter = 0;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void loginBtn_Click(object sender, EventArgs e)
        {
            //Checker1 ch1 = new Checker1();
            //Checker2 ch2 = new Checker2();
            //if (counter % 2 == 0)
            //    lblMessage.Text = ch1.Check(txbLogin.Text, txbPassword.Text);
            //else
            //    lblMessage.Text = ch2.Check(txbLogin.Text, txbPassword.Text);
            //counter++;
            ICheck ch = new Checker2();
            lblMessage.Text = ch.Check(txbLogin.Text, txbPassword.Text);
        }
    }
}