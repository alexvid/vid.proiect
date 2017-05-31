using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Windows.Forms;
using proiect.Models;

namespace admin
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.type = Convert.ToInt32(typetxt.Text);
            user.username = usertxt.Text;
            user.password = passtxt.Text;
            user.firstname = fnametxt.Text;
            user.lastname = lnametxt.Text;

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:58069/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.PostAsJsonAsync("api/addUser", user).Result;

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Operation succeded");
            }
            else
            {
                MessageBox.Show("Operation failed");
            }
        }

        private void Deletebtn_Click_1(object sender, EventArgs e)
        {
            User user = new User();
            user.ID = Convert.ToInt32(idtxt.Text);
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:58069/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.PostAsJsonAsync("api/deleteUser", user).Result;

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Operation succeded");
            }
            else
            {
                MessageBox.Show("Operation failed");
            }
        }


        private void Updatebtn_Click_1(object sender, EventArgs e)
        {
            User user = new User();
            user.ID = Convert.ToInt32(idtxt.Text);
            user.type = Convert.ToInt32(typetxt.Text);
            user.username = usertxt.Text;
            user.password = passtxt.Text;
            user.firstname = fnametxt.Text;
            user.lastname = lnametxt.Text;
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:58069/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.PostAsJsonAsync("api/updateUser", user).Result;

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Operation succeded");
            }
            else
            {
                MessageBox.Show("Operation failed");
            }
        }

        private void Viewbtn_Click_1(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:58069/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync("api/getusers").Result;

           

            if (response.IsSuccessStatusCode)
            {
                usergrid.DataSource = response.Content.ReadAsAsync<IList<User>>().Result;
            }
        }


    }
}
