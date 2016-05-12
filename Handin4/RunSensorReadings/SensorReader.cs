using System.Collections.Generic;
using System.Threading;
using Handin;
using Newtonsoft.Json;
using RunSensorReadings;

namespace HandinDB
{
    public class SensorReader
    {
        private int CurrentFile = 0;
        private ISensorAccess sensorAccess = new SensorAccess();
        
        public SensorReader()
        {
            for (int i = 0; i < 50; i++)
            {
                SaveReadingsToDatabase();
                Thread.Sleep(5000);
            }
        }

        private void SaveReadingsToDatabase()
        {
            var sensorList = ConvertFileToSensorList(ReadFile());
            var totalInsertions = 0;
            foreach (var sensor in sensorList)
            {
                //insert to database
                //sensorAccess.AddData(sensor.SensorId, sensor.AppartmentId, sensor.Value, sensor.Timestamp);
                System.Console.WriteLine("inserted to database: " + sensor.SensorId + ", " + sensor.AppartmentId + ", " + sensor.Value + ", " + sensor.Timestamp);
                totalInsertions++;
            }
            System.Console.WriteLine("Inserted a total of: " + totalInsertions + " sensor measures");
        }


        private List<GDLSensor> ConvertFileToSensorList(string jsonFile)
        {
            var sensorList = new List<GDLSensor>();
            var stringArray = jsonFile.Split('{', '}');
            
            for (int i = 2; i < stringArray.Length - 1; i += 2)
            {
                sensorList.Add(JsonConvert.DeserializeObject<GDLSensor>('{' + stringArray[i] + '}'));
            }
            return sensorList;
        }

        public string ReadFile()
        {
            CurrentFile++;
            return System.IO.File.ReadAllText(@"json/" +CurrentFile+ ".json");
        }
    }
}