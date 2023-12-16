using Exceptions.Models;

namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DateTime date1 = new DateTime(2023, 12, 10);
            //DateTime date2 = new DateTime(2023, 12, 15);
            //Meeting meeting1 = new Meeting(date1,date2,"Elxan");
            //Meeting meeting2 = new Meeting(date1,date2,"Murad");

            //MeetingSchedule meetingSchedule1 = new MeetingSchedule();
            //meetingSchedule1.SetMeeting("Elxan",date1,date2);
            //meetingSchedule1.SetMeeting("Murad",date1,date2);

            MeetingSchedule meet = new MeetingSchedule();

            try
            {
                meet.SetMeeting(new DateTime(2022, 10, 1), new DateTime(2022, 10, 5), "supper");
                meet.SetMeeting(new DateTime(2022, 10, 1), new DateTime(2022, 10, 5), "supper");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}