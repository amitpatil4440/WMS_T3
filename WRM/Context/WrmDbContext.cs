using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WRM.Models;

namespace WRM.Context
{
    public class WrmDbContext : DbContext
    {
        public WrmDbContext(DbContextOptions<WrmDbContext> Context) : base(Context)
        {

        }
        public DbSet<Passenger> PassengerTbl { get; set; }
        public DbSet<Staff> StaffTbl { get; set; }
        public DbSet<Supervisor> SupervisorTbl { get; set; }
        //public DbSet<WheelChair> WheelChairTbl { get; set; }
        public DbSet<SSR> WRequestTbl { get; set; }
        
    }

}
