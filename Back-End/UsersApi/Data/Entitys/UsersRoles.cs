using System;
using System.Collections.Generic;

namespace UsersApi.Data.Entitys
{
    public partial class UsersRoles
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }
    }
}
