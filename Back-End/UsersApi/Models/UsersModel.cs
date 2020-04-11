using System;
using System.Data.Common;
using System.Linq;
using UsersApi.Data.Context;
using UsersApi.Data.Entitys;
using UsersApi.Data.Entitys.Response;

namespace UsersApi.Models
{
    public class UsersModel
    {
        public LoginResponse Login (string userName, string pass)
        {
            try
            {
                using (undefinedDEMO2020Context context = new undefinedDEMO2020Context())
                {
                    var Query = context.Users.FirstOrDefault(x => x.UserName == userName && x.Pass == pass);
                                // join y in context.UsersRoles on x.id equals y.Roleid
                                // join z in context.Permissions on y.Roleid equals z.Moduleid
                                // select new LoginResponse
                                // {
                                //     User = x.UserName,
                                //     ModulesAllowed = z.Moduleid
                                // };
                                Console.WriteLine(Query.Id.ToString());

                }
                return new LoginResponse();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new LoginResponse();
            }
        }

    }
}