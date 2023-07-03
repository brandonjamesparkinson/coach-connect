namespace coach_connect_api.Models
{
    public class Coach
    {
        public int CoachId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        //public List<Client> CurrentClients { get; set; }  // currently paying for coaching
        //public List<Client> InactiveClients { get; set; } // not currently paying for coaching
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
