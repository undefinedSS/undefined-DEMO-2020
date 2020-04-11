using System;
using System.Data.Common;
using System.Linq;
using UsersApi.Data.Context;
using UsersApi.Data.Entitys;

namespace UsersApi.Models
{
    public class UsersModels
    {
        public string Login (string UserName, string Pass)
        {
            try
            {
                using (undefinedDEMO2020Context context = new undefinedDEMO2020Context())
                {
                    var Query = from x in context.Users where (x => x.UserName == UserName && x.Pass == Pass)
                                join y in context.UsersRoles on x.id equals y.Roleid
                                join z in context.Permissions on y.Roleid equals z.Moduleid
                                select new LoginResponse
                                {
                                    User = x.UserName,
                                    ModulesAllowed = z.Moduleid
                                };
                    return Query.toList();
                }
            }
            catch (Exception.ex)
            {
                return x.message;
            }
        }
    }
}