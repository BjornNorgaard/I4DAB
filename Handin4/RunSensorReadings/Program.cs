using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HandinDB;

namespace RunSensorReadings
{
    class Program
    {
        static void Main(string[] args)
        {
            var sensorReader = new SensorReader();

            //using (var db = new Handin4ModelContainer())
            //{
            //    db.Database.ExecuteSqlCommand("DELETE [Mesurements]");
            //    db.Database.ExecuteSqlCommand("DELETE [sensors]");
            //}
        }
    }
}
