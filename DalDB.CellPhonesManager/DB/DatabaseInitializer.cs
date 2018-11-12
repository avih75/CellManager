using Common.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DalDB.CellPhonesManager.DB
{
    public class DatabaseInitializer : DropCreateDatabaseAlways<CellPhonesManagerDB>
    {
        protected override void Seed(CellPhonesManagerDB context)
        {
            // create base data
            AddDeals(context);
            AddClients(context);
            AddSmss(context);
            AddCalls(context);
            AddCalls(context);
            AddReports(context);
            context.SaveChanges();
        }

        private void AddDeals(CellPhonesManagerDB context)
        {
            DtoDealOptionModel deal1 = new DtoDealOptionModel()
            {
                DealName = "50% Off On Sms",
                Description = "Every Sms Get 50% Discaunt",                
            };
            DtoDealOptionModel deal2 = new DtoDealOptionModel()
            {
                DealName = "50% Off On Calls",
                Description = "Every Call Get 50% Discaunt"
            };
            DtoDealOptionModel deal3 = new DtoDealOptionModel()
            {
                DealName = "50% Call Off On Family Numbers",
                Description = "Call You Family And Pay Only 50% Price Family List"
            };
            DtoDealOptionModel deal4 = new DtoDealOptionModel()
            {
                DealName = "50 Sms Free After 100 Sms",
                Description = "Get 50 Sms For Free If You Sended 100 Sms"
            };
            DtoDealOptionModel deal5 = new DtoDealOptionModel()
            {
                DealName = "200 Min Free After 500 Min",
                Description = "Get 200 Min For Free If You Arrive 500 Min"
            };
            DtoDealOptionModel deal6 = new DtoDealOptionModel()
            {
                DealName = "Free Group Call",
                Description = "Make Free Calls To The  Number In The Group List"
            };
            DtoDealOptionModel deal7 = new DtoDealOptionModel()
            {
                DealName = "25% Off On Call To Friends",
                Description = "Call To The Number In The Friends List in 25% Off The Price"
            };
            DtoDealOptionModel deal8 = new DtoDealOptionModel()
            {
                DealName = "Free Sms To Family",
                Description = "Send Free Sms To The Number In The Family List"
            };
            context.DbDealList.Add(deal1);
            context.DbDealList.Add(deal2);
            context.DbDealList.Add(deal3);
            context.DbDealList.Add(deal4);
            context.DbDealList.Add(deal5);
            context.DbDealList.Add(deal6);
            context.DbDealList.Add(deal7);
            context.DbDealList.Add(deal8);
        }
        private void AddClients(CellPhonesManagerDB context)
        {

        }
        private void AddCalls(CellPhonesManagerDB context)
        {

        }
        private void AddSmss(CellPhonesManagerDB context)
        {

        }
        private void AddReports(CellPhonesManagerDB context)
        {

        }
    }
}
