using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Models.Dtos
{
    public class DtoCallModel
    {
        public int Id { get; set; }
        public int CallerId { get; set; }
        public int TargetId { get; set; }
        public DateTime StartCall { get; set; }
        public DateTime EndCall { get; set; }
    }
}
