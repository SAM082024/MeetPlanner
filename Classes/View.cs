using System.ComponentModel.DataAnnotations;

public class View
{
    private Controller controller = new Controller();

    public void AskForMeetInfo()
    {
        Console.WriteLine("Skriv inn møte-ID:");
        string meetID = Console.ReadLine();

        Console.WriteLine("Skriv inn navn på deltagerne (kommaseparert):");
        List<string> participants = new List<string>(Console.ReadLine().Split(','));

        Console.WriteLine("Skriv inn tidspunkt for møtet (YYYY-MM-DD HH:MM):");
        DateTime timeFrame = DateTime.Parse(Console.ReadLine());

        controller.LeggTilMøte(meetID, participants, timeFrame);
    }

    public void WriteToFile(string fileName)
    {
        controller.WriteToFile(fileName);
    }
}