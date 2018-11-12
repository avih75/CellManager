using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Models
{
    public class CallModel
    {
        public int Id { get; set; }
        public int LineId { get; set; }
        public double Dureation { get; set; }
        public DateTime StartDate { get; set; }
        public string DestinationNumber { get; set; }
        public bool IsSameGroup { get; set; }
    }
}
