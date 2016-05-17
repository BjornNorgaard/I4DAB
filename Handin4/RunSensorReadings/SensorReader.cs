using System;
using System.Collections.Generic;
using System.Net;
using Handin;
using Newtonsoft.Json;
using RunSensorReadings;

namespace HandinDB
{
    public class SensorReader
    {
        private int _currentFile = 1;
        private readonly ISensorAccess _sensorAccess = new SensorAccess();
        private readonly WebClient _webClient = new WebClient();

        public SensorReader()
        {
            for (int i = 0; i < 11800; i++)
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
                if (
                    !_sensorAccess.AddData(sensor.SensorId, sensor.AppartmentId, sensor.Value,
                        DateTime.Parse(sensor.Timestamp)))
                    continue;

                Console.WriteLine("Inserted to database: " + sensor.SensorId + ", " + sensor.AppartmentId + ", " +
                                  sensor.Value + ", " + sensor.Timestamp);

                totalInsertions++;

            }
            Console.WriteLine
                ("Inserted a total of: " +
                 totalInsertions
                 + " sensor measures");
        }


        private static IEnumerable<GDLSensor> ConvertFileToSensorList(string jsonFile)
        {
            var tempSensorList = new List<GDLSensor>();
            var stringArray = jsonFile.Split('{', '}');

            for (int i = 2; i < stringArray.Length - 1; i += 2)
            {
                tempSensorList.Add(JsonConvert.DeserializeObject<GDLSensor>('{' + stringArray[i] + '}'));
            }
            return tempSensorList;
        }

        public string ReadFile()
        {
            return
                _webClient.DownloadString(@"http://userportal.iha.dk/~jrt/i4dab/E14/HandIn4/dataGDL/data/" +
                                          _currentFile++ +
                                  ".json");
        }
    }
}