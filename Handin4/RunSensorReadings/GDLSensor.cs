namespace RunSensorReadings
{
    public class GDLSensor
    {
        public int SensorId { get; set; }
        public int AppartmentId { get; set; }
        public double Value { get; set; }
        public string Timestamp { get; set; }

        public GDLSensor(int sensorId, int appartmentId, double value, string timestamp)
        {
            SensorId = sensorId;
            AppartmentId = appartmentId;
            Value = value;
            Timestamp = timestamp;
        }
    }
}