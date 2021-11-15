using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolSystem.Controllers
{
    public class RegisterViewController
    {
        public void AddUser(string username, string password)
        {
            MessageBox.Show("Потребителя " + username + " беше добавен успешно! Вече може да влезете в акаунта си.");
        }
    }
}
