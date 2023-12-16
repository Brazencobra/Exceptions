using Exceptions.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions.Models
{
    internal class MeetingSchedule
    {
        public Meeting[] meetings;

        public MeetingSchedule()
        {
            meetings = new Meeting[0];
        }

        public void SetMeeting(DateTime from,DateTime to,string fullname)
        {
            foreach (Meeting item in meetings)
            {
                if (from.Day != item.Fromdate.Day && to != item.ToDate)
                {
                    if (from.Day < to.Day)
                    {
                        Array.Resize(ref meetings,meetings.Length + 1);
                        Meeting meeting = new Meeting(from,to,fullname);
                        meetings[meetings.Length - 1] = meeting;
                    }
                    else
                    {
                        throw new WrongDateIntervalException("Yanlis rezervasiya parametrleri daxil edilib");
                    }
                }
                else
                {
                    throw new ReservedDateIntervalException("Yanlis rezervasiya parametrleri daxil edilib");
                }
                
            }
        }
    }
}
