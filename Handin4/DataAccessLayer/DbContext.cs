using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Handin;

namespace DataAccessLayer
{
    class Context : DbContext
    {
            public Context() : base("name=Handin4ModelContainer")
            {
            }

            protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                throw new UnintentionalCodeFirstException();
            }

            public virtual DbSet<Sensor> Sensors { get; set; }
            public virtual DbSet<Mesurement> Mesurements { get; set; }
    }
}
