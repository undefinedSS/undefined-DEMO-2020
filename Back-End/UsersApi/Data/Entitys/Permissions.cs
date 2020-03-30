using System;
using System.Collections.Generic;

namespace UsersApi.Data.Entitys
{
    public partial class Permissions
    {
        public int Id { get; set; }
        public int? RoleId { get; set; }
        public int? UserId { get; set; }
        public int? SubModuleId { get; set; }
        public int? ModuleId { get; set; }
    }
}
