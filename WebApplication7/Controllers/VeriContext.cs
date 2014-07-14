using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication7.Models;

namespace WebApplication7.Controllers
{
    public class VeriContext :DbContext 

    {
          public VeriContext()
            : base("name=db2c49817619c04dadaee7a36801018bf7Entities") { }

        public DbSet<Table> tables { get; set; }
    }
}