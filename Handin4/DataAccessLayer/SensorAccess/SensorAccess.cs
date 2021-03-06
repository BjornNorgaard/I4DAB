using System;
using System.Collections;
using System.Linq;
using DataAccessLayer;
using DataAccessLayer.Entities;

namespace Handin
{
    public class SensorAccess : ISensorAccess
    {
        public bool AddData(int sensorId, int apartmentId, double value, DateTime timestamp)
        {
            if (SensorExists(sensorId) == false)
            {
                if (CreateSensorInDb(sensorId, apartmentId) == false) return false;
            }

            if (CreateMesurement(sensorId,  value, timestamp) == false) return false;

            return true;
        }

        private bool CreateMesurement(int sensorId, double value, DateTime timestamp)
        {
            if (SensorExists(sensorId) == false) return false;

            Mesurement mesurement = new Mesurement() {SensorId = sensorId, Timestamp = timestamp, Value = value};

            using (var db = new Context())
            {
                db.Mesurements.Add(mesurement);
                db.SaveChanges();
            }

            return true;
        }
        
        private bool CreateSensorInDb(int sensorId, int apartmentId)
        {
            if (SensorExists(sensorId) == true) return false;

            Sensor sensor = new Sensor() {SensorId = sensorId, ApartmentId = apartmentId,};

            using (var db = new Context())
            {
                db.Sensors.Add(sensor);
                db.SaveChanges();
            }

            return true;
        }

        private bool SensorExists(int sensorId)
        {
            using (var db = new Context())
            {
                var searchSensor = from sensor in db.Sensors
                                   where sensor.SensorId == sensorId //&& sensor.ApartmentId == apartmentId
                                   select sensor;

                if (!searchSensor.Any()) return false;
                if (searchSensor.Count() > 1) throw new ArgumentException("Herro pree, more than one sensor was found!");
            }

            return true;
        }
    }
}