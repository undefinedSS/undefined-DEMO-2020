using System;
using System.Collections.Generic;

namespace UsersApi.Data.Entitys
{
    public partial class Persons
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int? Age { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public int? Phone { get; set; }
        public string Identification { get; set; }
    }
}
