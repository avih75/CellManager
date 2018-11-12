using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Models.Dtos
{
    public class DtoLineModel
    {
        public int Id { get; set; }
        public string LineNumber { get; set; }
        public List<DtoDealModel> DealsList { get; set; }
        public List<DtoCallModel> CallList { get; set; }
        public List<DtoSmsModel> SmsList { get; set; }
    }
}
