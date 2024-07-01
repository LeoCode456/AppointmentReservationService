namespace AppointmentService.Services
{
    public class Reservations
    {
        public static Reservation CreateReservationRecordDB(int userId, int appointment_Id)
        {
            return new Reservation();
        }

        public static Reservation GetReservationRecordDB(int userId, int reservation_Id)
        {
            return new Reservation();
        }
        public static Reservation UpdateReservationRecordDB(int userId, int reservation_Id)
        {
            return new Reservation();
        }

        public static Reservation DeleteReservationRecordDB(int userId, int reservation_Id)
        {
            return new Reservation();
        }

        public static List<Reservation> GetReservationListDB()
        {
            return new List<Reservation>();
        }
        public static void UpdateUpdateExpiredReservationsDB()
        {
            List<Reservation> reservations = Reservations.GetReservationListDB();
            foreach (Reservation reservation in reservations)
            {
                if(reservation.reservation_Date < DateTime.Now.AddDays(-1))
                {
                    reservation.reservation_Status = "Expired";
                }
            }

        }
    }
}