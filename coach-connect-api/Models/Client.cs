namespace coach_connect_api.Models
{
    public class Client
    {
        public int ClientId { get; set; }
        public bool IsActiveClient { get; set; } // example use is client has paid for coaching
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        //public List<DietPlan> DietPlans { get; set; }
        //public List<WorkoutPlan> WorkoutPlans { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string ClientGoal { get; set; }
    }
}
