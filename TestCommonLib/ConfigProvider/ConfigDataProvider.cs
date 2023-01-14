using Newtonsoft.Json;

namespace TestCommonLib.DataProvider
{
    public class ConfigDataProvider
    {
        private static readonly string _nameOfJsonFile = "Config.json";

        private static Config config; 

        public static Config GetData()
        {
            string objectJsonFile = File.ReadAllText(_nameOfJsonFile);
            config = JsonConvert.DeserializeObject<Config>(objectJsonFile);
            return config;
        }
    }
}
