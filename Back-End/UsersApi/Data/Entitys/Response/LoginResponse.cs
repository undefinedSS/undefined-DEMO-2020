namespace UsersApi.Data.Entitys.Response
{
    public class LoginResponse
    {
        public Users User { get; set; }
        public Int [] ModulesAllowed { get; set; }
        public Int [] SubModulesAllowed { get; set; }
    }
}