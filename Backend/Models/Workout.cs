namespace Trenings_logg_prosjekt.Backend.Models;

public class Workout
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public string Exercise { get; set; } = "";
    public int Weight { get; set; }
    public int Reps { get; set; }
}
