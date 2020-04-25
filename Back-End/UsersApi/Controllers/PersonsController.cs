using Microsoft.AspNetCore.Mvc;
using UsersApi.Models;

namespace UsersApi.Controllers
{
    [ApiController]
    [Route ("[controller]")]
    public class PersonsController : ControllerBase
    {
        [HttpPost]
        [Route("Create")]
        public ActionResult<string> Create (string name, string surname, int age, string address, string email, int phone, string identification)
        {
            var PersonsModel = new PersonsModel();
            return PersonsModel.Create (name, surname, age, address, email, phone, identification);
        }

        [HttpPost]
        [Route("Delete")]
        public ActionResult<string> Delete (int id)
        { 
            var PersonsModel = new PersonsModel();
            return PersonsModel.Delete (id);
        }

        [HttpPost]
        [Route("Update")]
        public ActionResult<string> Update (int id, string name, string surname, int age, string address, string email, int phone, string identification)
        {
            var PersonsModel = new PersonsModel();
            return PersonsModel.Update (id,name, surname, age, address, email, phone, identification);
        }
    }
}