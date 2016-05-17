using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using DataAccessLayer.Entities;
using Handin;

namespace DataAccessLayer
{
    class Context : DbContext
    {
            public Context() : base("name=Handin4ModelContainer")
            {
            }

            public virtual DbSet<Sensor> Sensors { get; set; }
            public virtual DbSet<Mesurement> Mesurements { get; set; }
    }
}
