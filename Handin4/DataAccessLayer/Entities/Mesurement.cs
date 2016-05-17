using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public partial class Mesurement
    {
        public int MesurementId { get; set; }
        public DateTime Timestamp { get; set; }
        public double Value { get; set; }
        public int SensorId { get; set; }

        public virtual Sensor Sensor { get; set; }
    }
}
