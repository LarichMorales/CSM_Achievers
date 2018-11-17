using Antlr.Runtime.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSM_Achievers.Infrastructure.Data.Enums
{
    public class LoginStatus
    {
        public static LoginStatus NewRegister { get; internal set; }

        Locked = 0,
        Action = 1,
        NeedsToChangePassword = 2,
        NewRegister = 3
    }
}