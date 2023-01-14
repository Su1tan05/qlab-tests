using Newtonsoft.Json;

namespace Mail.RU.Tests.DataProvider
{
    public class TestDataProvider
    {
        private static readonly string _nameOfJsonFile = "TestData.json";
        
        private static TestData testData;

        public static TestData GetData()
        {
            string objectJsonFile = File.ReadAllText(_nameOfJsonFile);
            testData = JsonConvert.DeserializeObject<TestData>(objectJsonFile);
            return testData;
        }
    }
}
