using Common.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Models.Dtos
{
    public class DtoClientModel
    {
        public int Id { get; set; }
        public LineStatusEnum ClientClass { get; set; }
        public List<LineModel> LinesList { get; set; }

        public string Name { get; set; }
        public string Address { get; set; }
        public string PersonalNumber { get; set; }
        public string Email { get; set; }
    }
}
