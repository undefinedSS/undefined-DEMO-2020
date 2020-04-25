using Microsoft.AspNetCore.Mvc;
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

        [HttpPost]
        [Route("Create")]
        public ActionResult<string> Create (string userName, string pass, int id, int type)
        {
            var usersModel = new UsersModel();
            return usersModel.Create (userName, pass, id, type);
        }

        [HttpPost]
        [Route("Delete")]
        public ActionResult<string> Delete (int id)
        { 
            var userModel = new UsersModel();
            return userModel.Delete (id);
        }

        [HttpPost]
        [Route("Update")]
        public ActionResult<string> Update (int id, string userName, string pass, int idPerson, int type)
        {
            var usersModel = new UsersModel();
            return usersModel.Update (id, userName, pass, idPerson, type);
        }
    }
}
