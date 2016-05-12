using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Handin;

namespace Handin4DB.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            ISensorAccess _sensorAccess = new SensorAccess();

            _sensorAccess.AddData(1, 2, 3, "4");
        }
    }
}
