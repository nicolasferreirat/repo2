using System;
using System.Text;

namespace Library
{
    public class AppointmentService
    {
        public static string CreateAppointment(string name, string phone, string email, DateTime date, string address, string doctor)
        {
            if (AppointmentValidator.ValidatorAppointment(name, phone, email, date, address, doctor))
            {
                return AppointmentRegister.RegisterAppointment(name, phone, email, date, address, doctor);
            }
            else
            {
                return "Appointment mistake";
            }
        }

    }

}