public class Model
{
    public string? MeetId { get; set; }

    public List<string> Participants { get; set; }

    public DateTime TimeFrame { get; set; }

    public Model(string meetId, List<string> participants, DateTime timeFrame)
    {
        MeetId = meetId;
        Participants = participants;
        TimeFrame = timeFrame;
    }
}