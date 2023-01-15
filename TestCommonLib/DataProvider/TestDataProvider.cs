using Newtonsoft.Json;

namespace TestCommonLib.DataProvider
{
    public class TestDataProvider
    {
        private static readonly string nameOfJsonFile = "BrowserSettings.json";
        
        public static BrowserSettings BrowserSettings =>
            JsonConvert.DeserializeObject<BrowserSettings>(File.ReadAllText(nameOfJsonFile));
        
        public static T GetData<T>(string nameOfJsonFile) =>
            JsonConvert.DeserializeObject<T>(File.ReadAllText(nameOfJsonFile));
    }
}
