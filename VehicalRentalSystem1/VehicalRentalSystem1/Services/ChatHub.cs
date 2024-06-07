using VehicalRentalSystem1.Models;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNetCore.Mvc;


namespace VehicalRentalSystem1.Services { 
    public class ChatHub : Hub
    {
        private readonly VehicalRentalSystemContext _context;

        public ChatHub(VehicalRentalSystemContext context) // Inject UserManager if using Identity
        {
            _context = context;
        }
      
        public async Task SendMessage(string message, Guid id)
        {
            var booking = _context.Bookings.FirstOrDefault(v => v.BookingId == id);
            var vehicle = _context.Vehicals.FirstOrDefault(v => v.VehicalId == booking.VehicalId);
            var user = _context.Vehicals.FirstOrDefault(v => v.UserId == vehicle.UserId);
            string guidString = $"{user.UserId}";
            if (user != null)
            {
                await Clients.User(guidString).SendAsync("ReceiveMessage", message); // Send to specific user
            }
        }
    }

}
