using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Models
{
    public class SMSModel
    {
        public int Id { get; set; }
        public int LineId { get; set; }
        public DateTime SendedDate { get; set; }
        public string DestinationNumber { get; set; }
    }
}
