using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Models
{
    public class ClientTypeModel
    {
        public int Id { get; set; }
        public string TypeName { get; set; }
        public double MinutePrice { get; set; }
        public double SMSPrice { get; set; }
    }
}
