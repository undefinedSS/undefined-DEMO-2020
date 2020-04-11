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
    }
}
