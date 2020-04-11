using System;
using Microsoft.AspNetCore.Mvc;
using UsersApi.Data.Entitys;
using UsersApi.Models;

namespace Usersapi.Controllers
{
    [Apicontroller]
    [Route ("/Controller/")]
    public class UsersController : ControllerBase
    {
        [httpGet]
        [Route("Login")]
        public ActionResult<Users> Login (string UserName, string Pass)
        {
            var UsersModel = new UsersModel();
            return UsersModel.Login (UserName, Pass);
        }
    }
}
