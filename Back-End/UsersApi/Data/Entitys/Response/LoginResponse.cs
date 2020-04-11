namespace UsersApi.Data.Entitys.Response
{
    public class LoginResponse
    {
        public Users User { get; set; }
        public int [] ModulesAllowed { get; set; }
        public int [] SubModulesAllowed { get; set; }
    }
}