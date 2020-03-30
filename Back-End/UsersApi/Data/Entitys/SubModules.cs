using System;
using System.Collections.Generic;

namespace UsersApi.Data.Entitys
{
    public partial class SubModules
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int IdModule { get; set; }
    }
}
