namespace AppointmentService
{
    public class Utility
    {
        public static IEnumerable<TimeSpan> Range(TimeSpan start, TimeSpan end)
        {
            for (var dt = start; dt <= end; dt = dt.Add(TimeSpan.FromMinutes(15)))
            {
                yield
                return dt;
            }
        }        
    }
}
