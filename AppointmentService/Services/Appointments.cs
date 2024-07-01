namespace AppointmentService.Services
{
    public class Appointments
    {
        public static List<Provider> GetClientAppointmentsFromProvidersDB()
        {
            List<Provider> listProviders = new List<Provider>();

            List<Appointment> listAppointments = new List<Appointment>();

            Appointment appointments = new Appointment
            {
                appoint_Id = 0,
                appointment_name = "Test",
                appointment_date = "7/1/2024",
                appointment_startTime = new TimeSpan(09, 0, 0),
                appointment_endTime = new TimeSpan(12, 0, 0)

            };

            listAppointments.Add(appointments);

            Appointment appointments1 = new Appointment
            {
                appoint_Id = 1,
                appointment_name = "Test1",
                appointment_date = "7/4/2024",
                appointment_startTime = new TimeSpan(08, 0, 0),
                appointment_endTime = new TimeSpan(12, 0, 0)

            };

            listAppointments.Add(appointments1);

            Provider provider = new Provider
            {
                provider_id = 1,
                provider_name = "P1",
                appointments = listAppointments
            };

            listProviders.Add(provider);

            List<Appointment> listAppointments1 = new List<Appointment>();
            Appointment appointments2 = new Appointment
            {
                appoint_Id = 2,
                appointment_name = "Test2",
                appointment_date = "7/5/2024",
                appointment_startTime = new TimeSpan(09, 0, 0),
                appointment_endTime = new TimeSpan(14, 0, 0)

            };
            listAppointments1.Add(appointments2);
            Appointment appointments3 = new Appointment
            {
                appoint_Id = 3,
                appointment_name = "Test3",
                appointment_startTime = new TimeSpan(08, 0, 0),
                appointment_endTime = new TimeSpan(15, 0, 0)
            };
            listAppointments1.Add(appointments3);

            Provider provider1 = new Provider
            {
                provider_id = 2,
                provider_name = "P2",
                appointments = listAppointments

            };

            listProviders.Add(provider1);

            return listProviders;
        }

        public static bool CheckReservation()
        {            
            return true;
        }
    }


    public class Provider
    {
        public int provider_id { get; set; }
        public string provider_name { get; set; }
        public List<Appointment> appointments { get; set; }

    }
    public class Appointment
    {
        public int appoint_Id { get; set; }
        public string appointment_name { get; set; }
        public string appointment_description { get; set; }
        public string appointment_type { get; set; }
        public string appointment_date { get; set; }
        public TimeSpan appointment_startTime { get; set; }
        public TimeSpan appointment_endTime { get; set; }
        public string appointment_year { get; set; }
        public Reservation reservation { get; set; }
    }

    public class Reservation
    {
        public int reservation_Id { get; set; }
        public string reservation_Name { get; set; }
        public string reservation_Description { get; set; }
        public string reservation_Status { get; set; }
        public string reservation_Type { get; set; }
        public DateTime reservation_Date { get; set; }
        public string reservation_Time { get; set; }
        public bool IsExpired { get; set; }
      
    }
}
