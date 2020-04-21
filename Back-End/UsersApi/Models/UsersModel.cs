using System;
using System.Linq;
using UsersApi.Data.Context;
using UsersApi.Data.Entitys;
using UsersApi.Data.Entitys.Response;
using System.Data;
using System.Collections.Generic;

namespace UsersApi.Models
{
    public class UsersModel
    {
        public LoginResponse Login (string userName, string pass)
        {
            try
            {
                undefinedDEMO2020Context context = new undefinedDEMO2020Context();
                var query = from u in context.Users
                            where u.UserName == userName && u.Pass == pass
                            join ur in context.UsersRoles on u.Id equals ur.UserId
                            join p in context.Permissions on ur.RoleId equals p.RoleId or u.id equals p.UserId 
                                select new 
                                {
                                    User = new Users
                                    {
                                        Id = u.Id,
                                        UserName = u.UserName,
                                        Pass = u.Pass,
                                        IdPerson = u.IdPerson,
                                        Type = u.Type,
                                    },
                                    ModulesAllowed = p.ModuleId,
                                    SubModulesAllowed = p.SubModuleId,
                                };
                LoginResponse loginResponse = new LoginResponse();
                if(query !=null)
                {
                    List<int> modulostmp = new List<int>();
                    List<int> submodulostmp = new List<int>();
                    foreach (var item in query)
                    {
                        loginResponse.User=item.User;
                        if (item.ModulesAllowed != null)
                        {
                            modulostmp.Add(item.ModulesAllowed.Value);
                        }
                        if (item.SubModulesAllowed != null)
                        {
                            submodulostmp.Add(item.SubModulesAllowed.Value);
                        }
                    }
                loginResponse.ModulesAllowed = modulostmp;
                loginResponse.SubModulesAllowed = submodulostmp;        
                }
                return loginResponse;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new LoginResponse();
            }
        }
    }
}