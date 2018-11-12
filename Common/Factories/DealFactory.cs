using Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Factories
{
   public static class DealFactory
    {
        public static AbstractDealModel GetNewDeal(string dealName)
        {
            var x =   Type.GetType("Common.Models."+dealName, true);
            AbstractDealModel report = (AbstractDealModel)Activator.CreateInstance((x));
            return (AbstractDealModel)report;
        }
    }
}
