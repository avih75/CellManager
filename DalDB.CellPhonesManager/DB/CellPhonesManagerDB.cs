using Common.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DalDB.CellPhonesManager.DB
{
    public class CellPhonesManagerDB : DbContext
    {
        public CellPhonesManagerDB()
            : base("name=CellPhoneManagerDB")
        {
            Database.SetInitializer(new DatabaseInitializer());
        }

        public virtual DbSet<DtoDealOptionModel> DbDealList { get; set; }
        public virtual DbSet<DtoClientModel> DbClientsList { get; set; }
        public virtual DbSet<DtoCallModel> DbCallsList { get; set; }
        public virtual DbSet<DtoSmsModel> DbSmssList { get; set; }
        public virtual DbSet<DtoReportBalanceModel> DbReportsList { get; set; }
    }
}
