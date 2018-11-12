using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Models.Dtos
{
    public class DtoReportBalanceModel
    {
        public int Id { get; set; }
        public string ClientName { get; set; }
        public int LineId { get; set; }
        public string LineNumber { get; set; }
        public DateTime BalanceDate { get; set; }
        public Double TotalAmount { get; set; }
        public string DealName { get; set; }
        public List<DtoSmsModel> SmsList { get; set; }
        public List<DtoCallModel> CallList { get; set; }
        // need to keep the deals data if need history
    }
}
