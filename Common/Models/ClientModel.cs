using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Models
{
    public class ClientModel : PersonModel
    {
        public ClientTypeModel TypeName { get; set; }
        public int CallsToCenter { get; set; }
    }
}
