using System.Collections.Generic;
using System.Threading;
using Newtonsoft.Json;

namespace HandinDB
{
    public class SensorReader
    {
        private int CurrentFile = 0;

        public SensorReader()
        {
            SaveReadingsToDatabase();
            Thread.Sleep(5000);
        }

        private void SaveReadingsToDatabase()
        {
            var sensorList = ConvertFileToSensorList(ReadFile());
            foreach (var sensor in sensorList)
            {
                //insert to database
                System.Console.WriteLine("inserted to database: " + sensor.sensorId +  sensor.appartmentId, sensor.value, sensor.timestamp);
            }
        }


        private List<Sensor> ConvertFileToSensorList(string jsonFile)
        {
            var sensorList = new List<Sensor>();
            var stringArray = jsonFile.Split('{', '}');
            
            for (int i = 2; i < stringArray.Length - 1; i += 2)
            {
                sensorList.Add(JsonConvert.DeserializeObject<Sensor>('{' + stringArray[i] + '}'));
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