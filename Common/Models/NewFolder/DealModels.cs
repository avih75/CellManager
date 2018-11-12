//using Common.Enums;
//using Common.Models.Dtos;
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Common.Models
//{
//    public class DealModel1 : AbstractDealModel
//    {
//        public DealModel1(int id, int dealId, DateTime endDate, double price)
//            : base(id, dealId, endDate, price)
//        {

//        }

//        public DealModel1(DtoDealModel deal)
//            : base(deal.Id, deal.DealId, deal.EndDate, deal.Price)
//        {

//        }

//        public override void MakeFirstDiscountCalc(List<Tuple<int, List<string>>> tplList, LineModel line, ref Double total)
//        {

//        }

//        public override void MakeLastDiscountCalc(List<Tuple<int, List<string>>> tplList, LineModel line, ref Double total)
//        {

//        }
//    }     // 50% off on sms 

//    public class DealModel2 : AbstractDealModel
//    {
//        public DealModel2(int id, int dealId, DateTime endDate, double price)
//            : base(id, dealId, endDate, price)
//        {

//        }

//        public DealModel2(DtoDealModel deal)
//            : base(deal.Id, deal.DealId, deal.EndDate, deal.Price)
//        {

//        }

//        public override void MakeFirstDiscountCalc(List<Tuple<int, List<string>>> tpl, LineModel line, ref Double total)
//        {
//            // manupilate the total 
//        }

//        public override void MakeLastDiscountCalc(List<Tuple<int, List<string>>> tpl, LineModel line, ref Double total)
//        {
//            // manupilate the total
//        }
//    }     // 50% off on calls

//    public class DealModel3 : AbstractDealModel
//    {
//        public DealModel3(int id, int dealId, DateTime endDate, double price)
//            : base(id, dealId, endDate, price)
//        {

//        }

//        public DealModel3(DtoDealModel deal)
//            : base(deal.Id, deal.DealId, deal.EndDate, deal.Price)
//        {

//        }

//        public override void MakeFirstDiscountCalc(List<Tuple<int, List<string>>> tpl, LineModel line, ref Double total)
//        {
//            // manupilate the total 
//        }

//        public override void MakeLastDiscountCalc(List<Tuple<int, List<string>>> tpl, LineModel line, ref Double total)
//        {
//            // manupilate the total
//        }
//    }     // 50% off on Family Numbers

//    public class DealModel4 : AbstractDealModel
//    {
//        public DealModel4(int id, int dealId, DateTime endDate, double price)
//            : base(id, dealId, endDate, price)
//        {

//        }

//        public DealModel4(DtoDealModel deal)
//            : base(deal.Id, deal.DealId, deal.EndDate, deal.Price)
//        {

//        }

//        public override void MakeFirstDiscountCalc(List<Tuple<int, List<string>>> tpl, LineModel line, ref Double total)
//        {
//            // manupilate the total 
//        }

//        public override void MakeLastDiscountCalc(List<Tuple<int, List<string>>> tpl, LineModel line, ref Double total)
//        {
//            // manupilate the total
//        }
//    }     // 50 sms free after 100 sms

//    public class DealModel5 : AbstractDealModel
//    {
//        public DealModel5(int id, int dealId, DateTime endDate, double price)
//            : base(id, dealId, endDate, price)
//        {

//        }

//        public DealModel5(DtoDealModel deal)
//            : base(deal.Id, deal.DealId, deal.EndDate, deal.Price)
//        {

//        }

//        public override void MakeFirstDiscountCalc(List<Tuple<int, List<string>>> tpl, LineModel line, ref Double total)
//        {
//            // manupilate the total 
//        }

//        public override void MakeLastDiscountCalc(List<Tuple<int, List<string>>> tpl, LineModel line, ref Double total)
//        {
//            // manupilate the total
//        }
//    }     // 200 min free after 500 min

//    public class DealModel6 : AbstractDealModel
//    {
//        public DealModel6(int id, int dealId, DateTime endDate, double price)
//            : base(id, dealId, endDate, price)
//        {

//        }

//        public DealModel6(DtoDealModel deal)
//            : base(deal.Id, deal.DealId, deal.EndDate, deal.Price)
//        {

//        }

//        public override void MakeFirstDiscountCalc(List<Tuple<int, List<string>>> tpl, LineModel line, ref Double total)
//        {
//            // manupilate the total 
//        }

//        public override void MakeLastDiscountCalc(List<Tuple<int, List<string>>> tpl, LineModel line, ref Double total)
//        {
//            // manupilate the total
//        }
//    }     // free call in Group

//    public class DealModel7 : AbstractDealModel
//    {
//        public DealModel7(int id, int dealId, DateTime endDate, double price)
//            : base(id, dealId, endDate, price)
//        {

//        }

//        public DealModel7(DtoDealModel deal)
//            : base(deal.Id, deal.DealId, deal.EndDate, deal.Price)
//        {

//        }

//        public override void MakeFirstDiscountCalc(List<Tuple<int, List<string>>> tpl, LineModel line, ref Double total)
//        {
//            // manupilate the total 
//        }

//        public override void MakeLastDiscountCalc(List<Tuple<int, List<string>>> tpl, LineModel line, ref Double total)
//        {
//            // manupilate the total
//        }
//    }     // 25% call to Friends

//    public class DealModel8 : AbstractDealModel
//    {
//        public DealModel8(int id, int dealId, DateTime endDate, double price)
//            : base(id, dealId, endDate, price)
//        {

//        }

//        public DealModel8(DtoDealModel deal)
//            : base(deal.Id, deal.DealId, deal.EndDate, deal.Price)
//        {

//        }

//        public override void MakeFirstDiscountCalc(List<Tuple<int, List<string>>> tpl, LineModel line, ref Double total)
//        {
//            // manupilate the total 
//        }

//        public override void MakeLastDiscountCalc(List<Tuple<int, List<string>>> tpl, LineModel line, ref Double total)
//        {
//            // manupilate the total
//        }
//    }     // free Sms to Family
//}
