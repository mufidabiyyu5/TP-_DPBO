﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    class Account
    {
        public Account()
        {

        }
        public string username { get; set; }
        public string password { get; set; }
        public Account(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
    }
}
