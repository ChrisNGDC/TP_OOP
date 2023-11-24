using System.Text.Json;

namespace TP_OOP
{
    internal class FileManager
    {
        private static List<Dictionary<string, string>> ReadJsonFile(string filename, Dictionary<string, string> newData)
        {
            var allData = new List<Dictionary<string, string>>();
            if (File.Exists(filename))
            {
                using StreamReader reader = new(filename);
                var jsonData = reader.ReadToEnd();
                var savedData = JsonSerializer.Deserialize<List<Dictionary<string, string>>>(jsonData)!;
                try
                {
                    allData.AddRange(savedData);
                }
                catch (ArgumentNullException) { /* Solo necesito que en caso de estar el archivo vacio, no me rompa ya que savedData seria null. */ }
                allData.Add(newData);
            }
            else
            {
                allData = new List<Dictionary<string, string>> { newData };
            }
            return allData;
        }
        public static void SaveToJsonFile(Dictionary<string, string> newData, string filename)
        {
            var allData = ReadJsonFile(filename, newData);
            using StreamWriter writer = new(filename, false);
            var jsonData = JsonSerializer.Serialize(allData);
            writer.Write(jsonData);
        }
    }
}
