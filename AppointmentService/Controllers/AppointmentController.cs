using AppointmentService.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AppointmentService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AppointmentController : Controller
    {
        private readonly ILogger<AppointmentController> _logger;

        [HttpPost("PostProviderAppointment")]
        public  bool PostProvAppointment(int userId, DateTime appointmentDate, DateTime startTime, DateTime endTime)
        {
           bool retval =  AppointmentRequest.InsertProviderAppointment(userId,appointmentDate,startTime,endTime);

            return retval;
        }

        [HttpGet("GetClientAppointments")]
        public List<Appointment> GetClientAvailableAppointments()
        {   
            return AppointmentRequest.GetClientAppointments();
        }

        [HttpPost("PutClientReservation")]
        public Reservation PostClientReservationRecord(int userId, int appointment_Id)
        {            
            return AppointmentRequest.ConvertAppointmentToReservation(userId, appointment_Id);
        }


        [HttpPost("PutClientConfirmation")]
        public Reservation PostClientConfirmationRecord(int userId, int appointment_Id)
        {
            return AppointmentRequest.ConfirmReservation(userId, appointment_Id);
        }

        [HttpPut("UpdateExpiredReservations")]
        public void UpdateExpiredReservations(int userId, int appointment_Id)
        {
           AppointmentRequest.UpdateExpiredReservations();
        }
    }
}
