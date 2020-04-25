using System;
using UsersApi.Data.Context;
using UsersApi.Data.Entitys;

namespace UsersApi.Models
{
    public class PersonsModel
    {
        undefinedDEMO2020Context context = new undefinedDEMO2020Context();
        public string Create (string name, string surname, int age, string address, string email, int phone, string identification)
        {
            try
            {
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

        public string Delete (int id)
        {
            try
            {
                Persons personDelete = context.Persons.Find(id);
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

        public string Update (int id, string name, string surname, int age, string address, string email, int phone, string identification)
        {
            try
            {
            Persons oldPerson = context.Persons.Find(id);
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