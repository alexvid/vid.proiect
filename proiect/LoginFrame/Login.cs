using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
using proiect.Models;
using Employee;
using admin;
namespace LoginFrame
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            passTxt.PasswordChar = '*';
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            //string username = userTxt.Text;
            //User test = new User();
            //test.username = "admin";
            //test.firstname = "alex";
            //test.lastname = "vid";
            //test.password = "admin";
            //test.type = 1;

            //HttpClient client = new HttpClient();
            //client.BaseAddress = new Uri("http://localhost:58069/");

            //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            //HttpResponseMessage response = client.PostAsJsonAsync("api/addUser", test).Result;
            //MessageBox.Show(response.ToString());
            //if (response.IsSuccessStatusCode)
            //{
            //    MessageBox.Show("Operation succeded");
            //}
            //else
            //{
            //    MessageBox.Show("Operation failed");
            //}

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:58069/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync("api/Login?data=" + userTxt.Text + "&data=" + passTxt.Text).Result;
            User user = new User();

            //MessageBox.Show(response.ToString());
            if (response.IsSuccessStatusCode)
            {
                user = response.Content.ReadAsAsync<User>().Result;

                if (user != null)
                    if (user.type == 1)
                    {
                        AdminForm adminForm = new AdminForm();
                        adminForm.Show();
                    }
                    else if (user.type == 2)
                    {
                        EmployeeForm empl = new EmployeeForm();
                        empl.Show();
                    }
            }
            else
            {
                MessageBox.Show("operation failed");
            }

        }

    }
}
