using System;
using System.Collections.Generic;
using System.Text;

namespace TCE_App.Tables
{
    public class RegisteredUsersTable
    {
        public Guid UserId { get; set; }
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }
    }
}
