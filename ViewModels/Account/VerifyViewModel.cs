using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CSM_Achievers.ViewModels.Account
{
    public class VerifyViewModel
    {
        public string EmailAddress { get; set; }

        public string RegistrationCode { get; set; }
    }
}