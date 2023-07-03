namespace coach_connect_api.Models
{
    public class Exercise
    {
        public int ExerciseId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int DurationInMinutes { get; set; }
        public int CaloriesBurned { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
