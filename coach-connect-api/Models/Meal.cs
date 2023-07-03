namespace coach_connect_api.Models
{
    public class Meal
    {
        public int MealId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<string> Ingredients { get; set; }
        public List<string> Instructions { get; set; }
        public int Calories { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
