using CSM_Achievers.Infrastructure.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CSM_Achievers.ViewModels.Account
{
    public class RegisterViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}