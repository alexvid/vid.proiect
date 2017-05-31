using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.OAuth;
using proiect.Models;
using proiect.Providers;
using proiect.Results;
using proiect.Providers;
namespace proiect.Controllers
{

    public class AccountController : ApiController
    {


        [HttpPost]
        [Route("api/addUser")]
        public void Post([FromBody]User user)
        {
            Security secure = new Security();
            user.password = secure.HashSHA1(user.password);
            DataProvide dp = new DataProvide();
            dp.addUser(user);
        }

        [HttpGet]
        [Route("api/Login")]
        public User Login([FromUri]string[] data)
        {
            DataProvide up = new DataProvide();
            User user = up.GetUser(data[0]);
            if (user != null)
            {
                Security secure = new Security();
                if (secure.VerifyHash(data[1], user.password))
                {
                    return user;
                }
            }
            return null;
        }

        [HttpPost]
        [Route("api/deleteUser")]
        public void Delete([FromBody]User user)
        {
            DataProvide up = new DataProvide();
            up.deleteUser(user);
        }

        [HttpPost]
        [Route("api/updateUser")]
        public void PostUpdate([FromBody]User user)
        {
            Security secure = new Security();
            user.password = secure.HashSHA1(user.password);
            DataProvide up = new DataProvide();
            up.updateUser(user);
        }

        [HttpGet]
        [Route("api/getUsers")]
        public IList<User> Get()
        {
            DataProvide up = new DataProvide();
            return up.getUsers();
        }

        [HttpPost]
        [Route("api/addClient")]
        public void addClient([FromBody]Client client)
        {

            DataProvide dp = new DataProvide();
            dp.addClient(client);
        }
        [HttpPost]
        [Route("api/deleteClient")]
        public void deleteClient([FromBody]Client client)
        {
            DataProvide up = new DataProvide();
            up.deleteClient(client);
        }
        [HttpPost]
        [Route("api/updateClient")]
        public void updateClient([FromBody]Client client)
        {
            DataProvide up = new DataProvide();
            up.updateClient(client);
        }
        [HttpGet]
        [Route("api/getClients")]
        public IList<Client> getClients()
        {
            DataProvide up = new DataProvide();
            return up.getClients();
        }

        [HttpPost]
        [Route("api/addVacantion")]
        public void addVacantion([FromBody]Vacantion vacantion)
        {

            DataProvide dp = new DataProvide();
            dp.addVacantion(vacantion);
        }
        [HttpGet]
        [Route("api/getVacantions")]
        public IList<Vacantion> getVacantions()
        {
            DataProvide up = new DataProvide();
            return up.getVacantions();
        }
        [HttpPost]
        [Route("api/updateVacantion")]
        public void updateVacantion([FromBody]Vacantion vacantion)
        {
            DataProvide up = new DataProvide();
            up.updateVacantion(vacantion);
        }

        [HttpPost]
        [Route("api/deleteVacantion")]
        public void deleteVacantion([FromBody]Vacantion vacantion)
        {
            DataProvide up = new DataProvide();
            up.deleteVacantion(vacantion);
        }
        [HttpGet]
        [Route("api/getBookedVacantions")]
        public IList<Vacantion> getBookedVacantions()
        {
            DataProvide up = new DataProvide();
            return up.getBookedVacantions();
        }
        [HttpGet]
        [Route("api/Reserv")]
        public string Reserv([FromUri]string[] data)
        {
            DataProvide up = new DataProvide();
            return up.Reserv(Convert.ToInt32(data[0]), Convert.ToInt32(data[1]), Convert.ToInt32(data[2]));

        }
    }
}
