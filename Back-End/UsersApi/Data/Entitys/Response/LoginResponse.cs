using System.Collections.Generic;

namespace UsersApi.Data.Entitys.Response
{
    public class LoginResponse
    {
        public Users User { get; set; }
        public List<int> ModulesAllowed { get; set; }
        public List<int> SubModulesAllowed { get; set; }
    }
}