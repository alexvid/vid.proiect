using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using proiect.Models;
using System.Configuration;
namespace proiect.Providers
{
    public class DataProvide
    {
        private string connString;

        public DataProvide()
        {
            connString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;

        }
        public void addUser(User user)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO user(Username,Password,FirstName,LastName,Type) VALUES(@username,@pass,@fname,@lname,@type)";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@username", user.username);
                cmd.Parameters.AddWithValue("@pass", user.password);
                cmd.Parameters.AddWithValue("@fname", user.firstname);
                cmd.Parameters.AddWithValue("@lname", user.lastname);
                cmd.Parameters.AddWithValue("@type", user.type);
                cmd.ExecuteNonQuery();
            }
        }
        public User GetUser(string userName)
        {

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string statement = "SELECT * FROM user where Username= \"" + userName + "\";";

                MySqlCommand cmd = new MySqlCommand(statement, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    {
                        User user = new User();
                        user.ID = reader.GetInt32("ID");
                        user.username = reader.GetString("Username");
                        user.password = reader.GetString("Password");
                        user.firstname = reader.GetString("FirstName");
                        user.lastname = reader.GetString("LastName");
                        user.type = reader.GetInt32("Type");
                        return user;
                    }
                }
            }

            return null;
        }
        public void deleteUser(User user)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "DELETE FROM user WHERE ID = @id";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@id", user.ID);
                cmd.ExecuteNonQuery();
            }
        }
        public void deleteClient(Client client)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "DELETE FROM client WHERE ID = @id";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@id", client.id);
                cmd.ExecuteNonQuery();
            }
        }
        public void updateUser(User user)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "UPDATE user SET Username=@username, Password=@pass, FirstName=@fname, LastName=@lname, Type=@type WHERE ID = @id";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@id", user.ID);
                cmd.Parameters.AddWithValue("@username", user.username);
                cmd.Parameters.AddWithValue("@pass", user.password);
                cmd.Parameters.AddWithValue("@fname", user.firstname);
                cmd.Parameters.AddWithValue("@lname", user.lastname);
                cmd.Parameters.AddWithValue("@type", user.type);
                cmd.ExecuteNonQuery();
            }
        }
        public IList<User> getUsers()
        {
            IList<User> userList = new List<User>();
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string statement = "SELECT * FROM user";

                MySqlCommand cmd = new MySqlCommand(statement, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        User user = new User();
                        user.ID = reader.GetInt32("ID");
                        user.username = reader.GetString("Username");
                        user.password = reader.GetString("Password");
                        user.lastname = reader.GetString("LastName");
                        user.firstname = reader.GetString("FirstName");
                        user.type = reader.GetInt32("Type");
                        userList.Add(user);
                    }
                }
            }
            return userList;
        }
        public void addClient(Client client)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO client(IDCode,FirstName,LastName,BirthDate,Address) VALUES(@IDCode,@FirstName,@LastName,@BirthDate,@Address)";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@IDCode", client.idCode);
                cmd.Parameters.AddWithValue("@FirstName", client.firstName);
                cmd.Parameters.AddWithValue("@LastName", client.lastName);
                cmd.Parameters.AddWithValue("@BirthDate", client.birthDate);
                cmd.Parameters.AddWithValue("@Address", client.address);
        
                cmd.ExecuteNonQuery();
            }
        }
        public void updateClient(Client client)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "UPDATE client SET IDCode=@IDCode, FirstName=@FirstName, LastName=@LastName, BirthDate=@BirthDate, Address=@Address WHERE ID = @id";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@id", client.id);
                cmd.Parameters.AddWithValue("@IDCode", client.idCode);
                cmd.Parameters.AddWithValue("@FirstName", client.firstName);
                cmd.Parameters.AddWithValue("@LastName", client.lastName);
                cmd.Parameters.AddWithValue("@BirthDate", client.birthDate);
                cmd.Parameters.AddWithValue("@Address", client.address);
                cmd.ExecuteNonQuery();
            }
        }
        public IList<Client> getClients()
        {
            IList<Client> clientList = new List<Client>();
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string statement = "SELECT * FROM client";

                MySqlCommand cmd = new MySqlCommand(statement, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Client client = new Client();
                        client.id = reader.GetInt32("ID");
                        client.idCode = reader.GetString("IDCode");
                        client.firstName = reader.GetString("FirstName");
                        client.lastName = reader.GetString("LastName");
                        client.birthDate = reader.GetDateTime("BirthDate");
                        client.address = reader.GetString("Address");
                        clientList.Add(client);
                    }
                }
            }
            return clientList;
        }
        public void addVacantion(Vacantion vacantion)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO vacations(Days,Schedule,Location,Disponibility) VALUES(@Days,@Schedule,@Location,@Disponibility)";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@Days", vacantion.Days);
                cmd.Parameters.AddWithValue("@Schedule", vacantion.Schedule);
                cmd.Parameters.AddWithValue("@Location", vacantion.Location);
                cmd.Parameters.AddWithValue("@Disponibility", vacantion.Disponibility);
                cmd.ExecuteNonQuery();
            }
        }
        public IList<Vacantion> getVacantions()
        {
            IList<Vacantion> VacantionList = new List<Vacantion>();
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string statement = "SELECT * FROM vacations where Disponibility >0";

                MySqlCommand cmd = new MySqlCommand(statement, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Vacantion vacantion = new Vacantion();
                        vacantion.ID = reader.GetInt32("ID");
                        vacantion.Days = reader.GetInt32("Days");
                        vacantion.Schedule = reader.GetDateTime("Schedule");
                        vacantion.Location = reader.GetString("Location");
                        vacantion.Disponibility = reader.GetInt32("Disponibility");
                        VacantionList.Add(vacantion);
                    }
                }
            }
            return VacantionList;
        }
        public void updateVacantion(Vacantion vacantion)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "UPDATE vacations SET Days=@Days, Schedule=@Schedule, Location=@Location, Disponibility=@Disponibility WHERE ID = @ID";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@ID", vacantion.ID);
                cmd.Parameters.AddWithValue("@Days", vacantion.Days);
                cmd.Parameters.AddWithValue("@Schedule", vacantion.Schedule);
                cmd.Parameters.AddWithValue("@Location", vacantion.Location);
                cmd.Parameters.AddWithValue("@Disponibility", vacantion.Disponibility);
                cmd.ExecuteNonQuery();
            }
        }
        public void deleteVacantion(Vacantion vacantion)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "DELETE FROM vacations WHERE ID = @id";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@id", vacantion.ID);
                cmd.ExecuteNonQuery();
            }
        }
        public IList<Vacantion> getBookedVacantions()
        {
            IList<Vacantion> VacantionList = new List<Vacantion>();
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string statement = "SELECT * FROM bookedVacations";

                MySqlCommand cmd = new MySqlCommand(statement, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Vacantion vacantion = new Vacantion();
                        vacantion.ID = reader.GetInt32("ID");
                        vacantion.IDClient = reader.GetInt32("IDClient");
                        vacantion.Days = reader.GetInt32("Days");
                        vacantion.Schedule = reader.GetDateTime("Schedule");
                        vacantion.Location = reader.GetString("Location");
                        vacantion.Disponibility = reader.GetInt32("Disponibility");
                        VacantionList.Add(vacantion);
                    }
                }
            }
            return VacantionList;
        }
        public void addBookedVacantion(Vacantion vacantion)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO bookedVacations(IDClient,Days,Schedule,Location,Disponibility) VALUES(@IDClient,@Days,@Schedule,@Location,@Disponibility)";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@IDClient", vacantion.IDClient);
                cmd.Parameters.AddWithValue("@Days", vacantion.Days);
                cmd.Parameters.AddWithValue("@Schedule", vacantion.Schedule);
                cmd.Parameters.AddWithValue("@Location", vacantion.Location);
                cmd.Parameters.AddWithValue("@Disponibility", vacantion.Disponibility);
                cmd.ExecuteNonQuery();
            }
        }
        public string Reserv(int ID,int IDClient,int People)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string statement = "select * from `vacations` where `ID`=" + ID + " and`Disponibility` >=" + People + ";";

                MySqlCommand cmd = new MySqlCommand(statement, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    Vacantion vacantion = new Vacantion();
                    while (reader.Read())
                    {
                        vacantion.ID = reader.GetInt32("ID");
                        vacantion.Days = reader.GetInt32("Days");
                        vacantion.Schedule = reader.GetDateTime("Schedule");
                        vacantion.Location = reader.GetString("Location");
                        vacantion.Disponibility = reader.GetInt32("Disponibility");

                        vacantion.Disponibility -= People;
                        vacantion.IDClient = IDClient;
                        updateVacantion(vacantion);
                        vacantion.Disponibility = People;
                        addBookedVacantion(vacantion);
                        return "Succes!";

                    }
                    


                }
            }
            return "Error!";
        }

    }
}