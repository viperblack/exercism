using System;

static class Appointment
{
    public static DateTime Schedule(string appointmentDateDescription)
    {
        var dateTime = DateTime.Parse(appointmentDateDescription);
        return dateTime;
    }

    public static bool HasPassed(DateTime appointmentDate)
    {
        int result = DateTime.Compare(DateTime.Now, appointmentDate);

        if (result > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static bool IsAfternoonAppointment(DateTime appointmentDate)
    {
        var meridiem = appointmentDate.ToString("tt");
        var hours = appointmentDate.Hour;
        var minutes = appointmentDate.Minute;

        bool result = (meridiem.Equals("PM") && hours <= 17 && minutes <= 59);

        return result;
    }

    public static string Description(DateTime appointmentDate)
    {
        return ("You have an appointment on " + appointmentDate + ".");
    }

    public static DateTime AnniversaryDate()
    {

        return new System.DateTime(DateTime.Now.Year, 9, 15);
    }
}
