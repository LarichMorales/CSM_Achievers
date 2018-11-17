using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CSM_Achievers.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}