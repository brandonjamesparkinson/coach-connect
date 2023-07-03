namespace coach_connect_api.Models
{
    public class DietPlan
    {
        public int DietPlanId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<Meal> Meals { get; set; }
        public List<string> Restrictions { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
