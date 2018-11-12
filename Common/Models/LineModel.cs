using Common.Enums;
using Common.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Models
{
    public class LineModel
    {
        public int Id { get; set; }
        public string ClientId { get; set; }
        public string Number { get; set; }
        public LineStatusEnum Status { get; set; }
        public int PackageId { get; set; }
        public string LineName { get; set; }
        public string GroupName { get; set; }
    }
    //public class xx
    //{
    //    public List<DtoCallModel> CallList { get; set; }
    //    public List<DtoSmsModel> SmsList { get; set; }
    //    public List<Tuple<int, List<string>>> ListsNumbers { get; set; }  // list of numbers and list kind

    //    public AbstractDealModel Deal { get; set; }

    //    public xx(DtoLineModel line)
    //    {
    //        // copy data
    //    }
    //    public xx()
    //    {

    //    }

    //    public DtoReportBalanceModel MakeReport(DateTime startDate, DateTime endDate)
    //    {
    //        DtoReportBalanceModel newReport = new DtoReportBalanceModel();
    //        LineModel lineToBill = DuplicateLineWithDate(startDate, endDate);
    //        newReport.SmsList = lineToBill.SmsList;
    //        newReport.CallList = lineToBill.CallList;
    //        newReport.LineId = Id;
    //        newReport.BalanceDate = endDate;
    //        newReport.TotalAmount = CalculateBill(lineToBill);
    //        newReport.LineNumber = Number;
    //        return newReport;
    //    }

    //    private LineModel DuplicateLineWithDate(DateTime startDate, DateTime endDate)
    //    {
    //        LineModel lineToReturn = new LineModel()
    //        {
    //            CallList = new List<DtoCallModel>(),
    //            SmsList = new List<DtoSmsModel>(),
    //            Id = Id,
    //            PackageId = PackageId,
    //            Number = Number,
    //            Deal = Factories.DealFactory.GetNewDeal(PackageId.ToString())
    //        };
    //        foreach (DtoCallModel call in CallList)
    //        {
    //            if (call.StartCall < endDate)
    //                lineToReturn.CallList.Add(call);
    //        }
    //        foreach (DtoSmsModel sms in SmsList)
    //        {
    //            if (sms.SendingDate < endDate)
    //                lineToReturn.SmsList.Add(sms);
    //        }
    //        return lineToReturn;
    //    }

    //    private double CalculateBill(LineModel lineToBill)
    //    {
    //        double total = 0;
    //        Deal.MakeFirstDiscountCalc(ListsNumbers, this, ref total);
    //        CalculateSms(ref total);
    //        CalculateCalls(ref total);
    //        Deal.MakeLastDiscountCalc(ListsNumbers, this, ref total);
    //        return total;
    //    }

    //    private void CalculateSms(ref double total)
    //    {
    //        // calculate the Sms
    //    }
    //    private void CalculateCalls(ref double total)
    //    {
    //        // calculate the Calls
    //    }

    //}


}
