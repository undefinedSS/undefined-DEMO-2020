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
                            join p in context.Permissions on ur.RoleId equals p.RoleId //|| u.Id equals p.UserId
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

        public string Create (string userName, string pass, int idPerson, int type, string name, string surname, int age, string address, string email, int phone, string identification)
        {
            try
            {
                undefinedDEMO2020Context context = new undefinedDEMO2020Context();
                Users user = new Users()
                {
                    UserName = userName,
                    Pass = pass,
                    IdPerson = idPerson,
                    Type = type,
                };
                Persons person = new Persons()
                {
                    Name = name,
                    Surname = surname,
                    Age = age,
                    Address = address, 
                    Email = email,         
                    Phone = phone,         
                    Identification = identification,
                };
                context.Users.Add(user);
                context.Persons.Add(person);
                context.SaveChanges();
                return "";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return ex.Message;
            }
        }

        public string Delete (int idUser, int idPerson)
        {
            try
            {
                undefinedDEMO2020Context context = new undefinedDEMO2020Context();
                Users userDelete = context.Users.Find(idUser);
                Persons personDelete = context.Persons.Find(idPerson);
                context.Users.Remove(userDelete);
                context.Persons.Remove(personDelete);
                context.SaveChanges();
                return "";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return ex.Message;
            }
        }

        public string Update (int idUser, string userName, string pass, int idPerson, int type, string name, string surname, int age, string address, string email, int phone, string identification)
        {
            try
            {
            undefinedDEMO2020Context context = new undefinedDEMO2020Context();
            Users oldUser;
            Persons oldPerson;
            oldUser = context.Users.Where(u => u.Id == idUser).FirstOrDefault();
            oldPerson = context.Persons.Where(u => u.Id == idPerson).FirstOrDefault();
            if (oldUser !=null)
            {
                oldUser.UserName = userName;
                oldUser.Pass = pass;
                oldUser.Type = type;
                context.SaveChanges();
            }
            if (oldPerson !=null)
            {
                oldPerson.Name = name;
                oldPerson.Surname = surname;
                oldPerson.Age = age;
                oldPerson.Address = address;
                oldPerson.Email = email;
                oldPerson.Phone = phone;
                oldPerson.Identification = identification;
                context.SaveChanges();
            }
            return "";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return ex.Message;
            }
        }
    }
}