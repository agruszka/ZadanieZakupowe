using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ZakupowyProjekt.Models
{
    public class AppContext : DbContext
    {
        public AppContext() : base("ZadanieZakupowe")

        {

        }

        public DbSet<DbModel> DbModels { get; set; }
    }
}