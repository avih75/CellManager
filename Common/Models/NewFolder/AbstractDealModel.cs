using Common.Enums;
using Common.Factories;
using Common.Models.Dtos;
using System;
using System.Collections.Generic;

namespace Common.Models
{
    abstract public class AbstractDealModel
    {
        public int Id { get; set; }
        public int DealId { get; set; }  // Fkey to deal
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Double Price { get; set; }
        public double Percent { get; set; }
        public double Quantity { get; set; }

        public AbstractDealModel(int id, int dealId, DateTime endDate, DateTime startDate, Double price)
        {
            Id = id;
            DealId = dealId;
            EndDate = endDate;
            Price = price;
            StartDate = startDate;
        }

        abstract public void MakeFirstDiscountCalc(List<Tuple<int, List<string>>> tplList, LineModel line, ref Double total);
        abstract public void MakeLastDiscountCalc(List<Tuple<int, List<string>>> tplList, LineModel line, ref Double total);
    }
}
