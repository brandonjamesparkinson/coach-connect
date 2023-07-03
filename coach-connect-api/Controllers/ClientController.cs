using coach_connect_api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace coach_connect_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly DataContext _context;

        public ClientController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Client>> GetAllClients()
        {
            var clients = _context.Clients.ToList();
            return Ok(clients);
        }

        [HttpGet("{id}")]
        public ActionResult<Client> GetClientById(int id)
        {
            var client = _context.Clients.FirstOrDefault(c => c.ClientId == id);
            if (client == null)
            {
                return NotFound();
            }

            return Ok(client);
        }

        [HttpPost]
        public ActionResult<Client> CreateClient(Client client)
        {
            _context.Clients.Add(client);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetClientById), new { id = client.ClientId }, client);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateClient(int id, Client updatedClient)
        {
            var client = _context.Clients.FirstOrDefault(c => c.ClientId == id);
            if (client == null)
            {
                return NotFound();
            }

            // Update client properties
            client.FirstName = updatedClient.FirstName;
            client.LastName = updatedClient.LastName;
            client.IsActiveClient = updatedClient.IsActiveClient;
            client.BirthDate = updatedClient.BirthDate;
            client.Email = updatedClient.Email;
            client.PhoneNumber = updatedClient.PhoneNumber;
            //client.DietPlans = updatedClient.DietPlans;
            //client.WorkoutPlans = updatedClient.WorkoutPlans;
            client.CreatedAt = updatedClient.CreatedAt;
            client.UpdatedAt = updatedClient.UpdatedAt;
            client.ClientGoal = updatedClient.ClientGoal;

            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteClient(int id)
        {
            var client = _context.Clients.FirstOrDefault(c => c.ClientId == id);
            if (client == null)
            {
                return NotFound();
            }

            _context.Clients.Remove(client);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
