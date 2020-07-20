using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace MadPay724.Data.DataBaseContext
{
    class MadPayDbcontext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Data Source=.\SQL2017;Initial catalog=MadPay;Integrated security=true;MultipleActiveResultSets=true");
        }
    }
}
