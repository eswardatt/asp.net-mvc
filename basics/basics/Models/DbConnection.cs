using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace basics.Models
{
    public class DbConnection:DbContext
    {
        public DbSet<Emplpoyee> Emplpoyees { get; set; }
    }
}