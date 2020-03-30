using System;
using System.Collections.Generic;

namespace UsersApi.Data.Entitys
{
    public partial class Users
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Pass { get; set; }
        public int IdPerson { get; set; }
        public int Type { get; set; }
    }
}
