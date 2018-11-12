using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Models.Dtos
{
     public class DtoSmsModel
    {
        public int Id { get; set; }
        public int SenderId { get; set; }
        public int ReciverId { get; set; }
        public DateTime SendingDate { get; set; }
    }
}
