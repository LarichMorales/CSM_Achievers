using CSM_Achievers.Infrastructure.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSM_Achievers.Infrastructure.Models
{
    public class UserRole
    {
        public Guid? UserId { get; set; }

        public Role Role { get; set; }
    }
}