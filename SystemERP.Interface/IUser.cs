﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SystemERP.Interface
{
    public interface IUser
    {
        public int Id { get; set; } 
        public string? Name { get; set; }
        public string? Password { get; set; }
        public int State { get; set; }
        public int Id_Role { get; set; }
    }
}