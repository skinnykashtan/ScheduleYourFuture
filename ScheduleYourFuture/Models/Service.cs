namespace ScheduleYourFuture.Models;

public class Service
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int DurationMinutes { get; set; }
    public decimal Price { get; set; }
    public int TrainerId { get; set; }
    public User Trainer { get; set; }
}