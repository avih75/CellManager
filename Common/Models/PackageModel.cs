using Common.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Models
{
    public class PackageModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Double Price { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double SMSQuantity { get; set; }
        public double CallsQuantity { get; set; }
        public double CallPercentage { get; set; }
        public double SMSPercentage { get; set; }
        public List<string> FavoriteNumbers { get; set; }
        public double FavoriteDiscount { get; set; }
        public DiscountTypeEnum FavoriteType { get; set; }
        public double GroupDiscount { get; set; }
        public DiscountTypeEnum GroupType { get; set; }
        public double MostCalledDiscount { get; set; }
        public DiscountTypeEnum MostCalledType { get; set; }
        public double InsideFamilyCalledDiscount { get; set; }
        public DiscountTypeEnum InsideFamilyCalledType { get; set; }
    }
}
