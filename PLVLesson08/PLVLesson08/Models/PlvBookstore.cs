using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PLVLesson08.Models
{
    public class PlvBookstore:DbContext
    {
        public PlvBookstore() : base("PlvBookStoreConnectionStrings")
        {
        }
        public DbSet<PlvCategory> plvCategories { get; set; }
        public DbSet<PlvBook> plvBooks { get; set; }
    }
}