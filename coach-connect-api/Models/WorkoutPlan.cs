namespace coach_connect_api.Models
{
    public class WorkoutPlan
    {
        public int WorkoutPlanId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Exercise> Exercises { get; set; }
        public int DurationInMinutes { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
