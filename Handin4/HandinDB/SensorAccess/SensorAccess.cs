using System;
using System.Linq;
using HandinDB;

namespace Handin
{
    public class SensorAccess : ISensorAccess
    {
        public bool AddData(int sensorId, int apartmentId, double value, string timestamp)
        {
            if (SensorExists(sensorId, apartmentId))
            {
                if (CreateSensorInDb(sensorId, apartmentId) == false) return false;
            }

            if (CreateMesurement(sensorId, apartmentId, value, timestamp) == false) return false;

            return true;
        }

        private bool CreateMesurement(int sensorId, int apartmentId, double value, string timestamp)
        {
            if (SensorExists(sensorId, apartmentId) == false) return false;

            Mesurement mesurement = new Mesurement() {SensorId = sensorId, Timestamp = timestamp, Value = value};

            using (var db = new HandinContext())
            {
                db.Mesurements.Add(mesurement);
            }

            return true;
        }
        
        private bool CreateSensorInDb(int sensorId, int apartmentId)
        {
            if (SensorExists(sensorId, apartmentId) == true) return false;

            Sensor sensor = new Sensor() {SensorId = sensorId, AppartmentId = apartmentId};

            using (var db = new HandinContext())
            {
                db.Sensors.Add(sensor);
            }

            return true;
        }

        private bool SensorExists(int sensorId, int apartmentId)
        {
            using (var db = new HandinContext())
            {
                var searchSensor = from sensor in db.Sensors
                                   where sensor.SensorId == sensorId && sensor.AppartmentId == apartmentId
                                   select sensor;

                if (searchSensor.Count() < 1) return false;
                if (searchSensor.Count() > 1) throw new ArgumentException("Herro pree, more than one sensor was found!");
            }

            return true;
        }
    }
}