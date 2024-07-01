using System.Collections.Generic;

namespace AppointmentService.Services
{
    public class AppointmentRequest
    {
        public static bool InsertProviderAppointment(int userId, DateTime appointmentDate, DateTime startTime, DateTime endTime)
        {
            //Database insert
            return true;           
        }
        public static List<Appointment> GetClientAppointments()
        {
            List<Provider> providerAppointments = Appointments.GetClientAppointmentsFromProvidersDB();

            List<Appointment> appointmentList = new List<Appointment>();

            foreach (Provider provider in providerAppointments)
            {
                foreach (Appointment appointment in provider.appointments)
                {
                   var apptRange = Utility.Range(appointment.appointment_startTime, appointment.appointment_endTime);

                    foreach (TimeSpan appt in apptRange)
                    {
                        Appointment appointmentAppointment = new Appointment
                        {
                            appoint_Id = 1
                          
                        };
                    }
                }
            }

            return appointmentList;
        }

        public static Reservation ConvertAppointmentToReservation(int userId, int appointment_Id)
        {
            Reservation reservation = Reservations.CreateReservationRecordDB(userId, appointment_Id);

            return reservation;
        }

        public static Reservation ConfirmReservation(int userId, int reservation_Id)
        {
            Reservation reservation = Reservations.GetReservationRecordDB(userId, reservation_Id);
            Reservation retunrReservation = new Reservation();
            if (reservation != null)
            {
                if (reservation.reservation_Date < DateTime.Now.AddDays(-1))
                {
                    retunrReservation.reservation_Status = "Reservations must be made at least 24 hours in advance";
                }
                else
                {
                    retunrReservation = Reservations.UpdateReservationRecordDB(userId, reservation_Id);
                    retunrReservation.reservation_Status = "Reservation booked";
                }
            }

            return retunrReservation;
        }

        public static void UpdateExpiredReservations()
        {
            Reservations.UpdateUpdateExpiredReservationsDB();
            
        }
    }
}