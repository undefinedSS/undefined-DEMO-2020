using System;
using Microsoft.AspNetCore.Mvc;
using UsersApi.Data.Entitys;
using UsersApi.Models;
using UsersApi.Data.Entitys.Response;

namespace UsersApi.Controllers
{
    [ApiController]
    [Route ("[controller]")]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        [Route("Login")]
        public ActionResult<LoginResponse> Login (string userName, string pass)
        {
            var usersModel = new UsersModel();
            return usersModel.Login (userName, pass);
        }

        [HttpGet]
        [Route("Create")]
        public ActionResult<string> Create (string userName, string pass, int idPerson, int type, string name, string surname, int age, string address, string email, int phone, string identification)
        {
            var usersModel = new UsersModel();
            return usersModel.Create (userName, pass, idPerson, type, name, surname, age, address, email, phone, identification);
        }

        [HttpGet]
        [Route("Delete")]
        public ActionResult<string> Delete (int idUser, int idPerson)
        { 
            var userModel = new UsersModel();
            return userModel.Delete (idUser, idPerson);
        }

        [HttpGet]
        [Route("Update")]
        public ActionResult<string> Update (int idUser, string userName, string pass, int idPerson, int type, string name, string surname, int age, string address, string email, int phone, string identification)
        {
            var usersModel = new UsersModel();
            return usersModel.Update (idUser, userName, pass, idPerson, type, name, surname, age, address, email, phone, identification);
        }
    }
}
