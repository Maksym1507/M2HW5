using System;
using System.IO;
using M2HW5.Configs;
using M2HW5.Interfaces;
using Newtonsoft.Json;

namespace M2HW5.Services
{
    public class DirectoryConfigurationService : IDirectoryConfigurationService
    {
        public DirectoryConfigurationService()
        {
            DirectoryConfiguration = new DirectoryConfiguration();
        }

        private DirectoryConfiguration DirectoryConfiguration { get; }

        public void SerializeDirectory(string jsonFile)
        {
            var stringJsonFile = JsonConvert.SerializeObject(DirectoryConfiguration.Directory.LogsPath);
            File.WriteAllText(jsonFile, stringJsonFile);
        }

        public string DeserializeDirectory(string jsonFile)
        {
            SerializeDirectory(jsonFile);
            var configFile = File.ReadAllText(jsonFile);
            return JsonConvert.DeserializeObject<string>(configFile);
        }
    }
}
