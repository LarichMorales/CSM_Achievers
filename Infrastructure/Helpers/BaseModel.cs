using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSM_Achievers.Infrastructure.Helpers
{
    public class BaseModel
    {
        public Guid? Id { get; set; }

        public DateTime Timestamp { get; set; }

        public BaseModel()
        {
            this.Timestamp = DateTime.UtcNow;
        }
    }
}