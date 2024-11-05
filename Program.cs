using System.Runtime.InteropServices.Marshalling;

namespace MeetPlanner;

class Program
{
    static void Main(string[] args)
    {
        // Instantiate the View to interact with the user
        View view = new View();

        Console.WriteLine("Welcome to the Meeting Planner!");

        // Collect meeting information from the user
        view.AskForMeetInfo();

        // Prompt for the file name to save the meeting information
        Console.WriteLine("Enter the file name to save the meeting information (e.g., 'meetings.json'):");
        string? fileName = Console.ReadLine();

        // Save the meeting data to the specified file
        view.WriteToFile(fileName);

        Console.WriteLine($"Meeting information has been saved to {fileName}");
    }
}
