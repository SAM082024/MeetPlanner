public class Controller
{
    private List<Model> meets = new List<Model>();

    public void LeggTilMøte(string meetId, List<string> participants, DateTime timeFrame)
    {
        Model newMeet = new Model(meetId, participants, timeFrame);
        meets.Add(newMeet);
    }
}