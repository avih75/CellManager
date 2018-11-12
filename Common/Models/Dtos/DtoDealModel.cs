using Common.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Models.Dtos
{
    public class DtoDealModel
    {
        public int Id { get; set; }
        public int DealId { get; set; }  // Fkey to deal
        public DateTime EndDate { get; set; }
        public Double Price { get; set; }

        public Tuple<ListKindEnum, List<string>> ListsNumbers { get; set; }  // list of numbers and list kind
    }
}
