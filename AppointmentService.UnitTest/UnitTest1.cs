using AppointmentService.Controllers;

namespace AppointmentService.UnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void Post_ProviderAppointment_Success()
        {
            //Arrange
            var appController = new AppointmentController();

            int userId= 1;
            DateTime appointmentDate = new DateTime();
            DateTime startTime = new DateTime();
            DateTime endTime = new DateTime();

            //Act
           bool actResult = appController.PostProvAppointment(userId, appointmentDate, startTime, endTime);


            //Assert
           bool testResult = actResult  == true ? true : false;
        }
    }
}