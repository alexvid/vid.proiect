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

namespace Employee
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                Client client1 = new Client();
                client1.idCode = txtIDCode.Text;
                client1.firstName = txtFirstName.Text;
                client1.lastName = txtLastName.Text;
                client1.birthDate = dateBirthDate.Value;
                client1.address = txtAddress.Text;

                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:58069/");

                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = client.PostAsJsonAsync("api/addClient", client1).Result;

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Operation succeded");
                }
                else
                {
                    MessageBox.Show("Operation failed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            try
            {
                Client client1 = new Client();
                client1.id = Convert.ToInt32(txtID.Text);
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:58069/");

                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = client.PostAsJsonAsync("api/deleteClient", client1).Result;

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Operation succeded");
                }
                else
                {
                    MessageBox.Show("Operation failed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void Updatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                Client client1 = new Client();
                client1.id = Convert.ToInt32(txtID.Text);
                client1.idCode = txtIDCode.Text;
                client1.firstName = txtFirstName.Text;
                client1.lastName = txtLastName.Text;
                client1.birthDate = dateBirthDate.Value;
                client1.address = txtAddress.Text;
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:58069/");

                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = client.PostAsJsonAsync("api/updateClient", client).Result;

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Operation succeded");
                }
                else
                {
                    MessageBox.Show("Operation failed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Viewbtn_Click(object sender, EventArgs e)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:58069/");

                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = client.GetAsync("api/getClients").Result;


                if (response.IsSuccessStatusCode)
                {
                    usergrid.DataSource = response.Content.ReadAsAsync<IList<Client>>().Result;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddVacantion_Click(object sender, EventArgs e)
        {
            try
            {
                Vacantion vacantion = new Vacantion();
                vacantion.Days = Convert.ToInt32(txtVacDays.Text);
                vacantion.Schedule = datetxtVacSch.Value;
                vacantion.Location = txtVacLoc.Text;
                vacantion.Disponibility = Convert.ToInt32(txtVacDispo.Text);

                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:58069/");

                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = client.PostAsJsonAsync("api/addVacantion", vacantion).Result;

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Operation succeded");
                }
                else
                {
                    MessageBox.Show("Operation failed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnViewVacantion_Click(object sender, EventArgs e)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:58069/");

                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = client.GetAsync("api/getVacantions").Result;


                if (response.IsSuccessStatusCode)
                {
                    dataGridView1.DataSource = response.Content.ReadAsAsync<IList<Vacantion>>().Result;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdateVacantion_Click(object sender, EventArgs e)
        {
            try
            {
                Vacantion vacantion = new Vacantion();
                vacantion.ID = Convert.ToInt32(txtVacId.Text);
                vacantion.Days = Convert.ToInt32(txtVacDays.Text);
                vacantion.Schedule = datetxtVacSch.Value;
                vacantion.Location = txtVacLoc.Text;
                vacantion.Disponibility = Convert.ToInt32(txtVacDispo.Text);

                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:58069/");

                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = client.PostAsJsonAsync("api/updateVacantion", vacantion).Result;

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Operation succeded");
                }
                else
                {
                    MessageBox.Show("Operation failed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteVacantion_Click(object sender, EventArgs e)
        {
            try
            {
                Vacantion vacantion = new Vacantion();
                vacantion.ID = Convert.ToInt32(txtVacId.Text);

                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:58069/");

                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = client.PostAsJsonAsync("api/deleteVacantion", vacantion).Result;

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Operation succeded");
                }
                else
                {
                    MessageBox.Show("Operation failed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            try
            {
                string ID = txtIDBookedVac.Text;
                string IDClient = txtIDClient.Text;
                string People = txtPeople.Text;
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:58069/");

                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = client.GetAsync("api/Reserv?data=" + ID + "&data=" + IDClient + "&data=" + People).Result;



                MessageBox.Show(response.Content.ReadAsAsync<string>().Result);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnBookedVac_Click(object sender, EventArgs e)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:58069/");

                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = client.GetAsync("api/getBookedVacantions").Result;


                if (response.IsSuccessStatusCode)
                {
                    dataGridView2.DataSource = response.Content.ReadAsAsync<IList<Vacantion>>().Result;
                }
                else
                {
                    MessageBox.Show("Operation failed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
