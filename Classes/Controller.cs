using System.Collections.Generic;
using System.IO;
using System.Text.Json; // Add this using directive
public class Controller
{
    private List<Model> meets = new List<Model>();

    public void LeggTilMøte(string meetId, List<string> participants, DateTime timeFrame)
    {
        Model newMeet = new Model(meetId, participants, timeFrame);
        meets.Add(newMeet);
    }

    public void WriteToFile(string fileName)
    {
        // Use System.Text.Json to serialize with indented formatting
        var options = new JsonSerializerOptions { WriteIndented = true };
        string json = JsonSerializer.Serialize(meets, options);
        File.WriteAllText(fileName, json);
    }
}