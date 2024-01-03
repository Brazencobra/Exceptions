using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions.Models
{
    internal class Meeting
    {
        /*
        Meeting class:
        -FromDate
        -ToDate
        -FullName
 
        MeetingSchedule class:
        Meetings - Meeting array-ı
        SetMeeting(fullname,from,to) - gonderilmis deyerlere esasen meeting yaratmaga calisir.Eger Gonderilmis tarix intervalinda meeting varsa geriye ReservedDateInterval exception qaytarir, eger gonderilen fromdate todate-den kicik deyilse WrongDateInterval exception qaytarir, her sey okaydirse meeting obyekti yaradib meeting listine add edir
        */


        private DateTime _fromdate;
        private DateTime _todate;
        private string _fullname;

        public DateTime Fromdate 
        {
            get => _fromdate; 
            set 
            {
                _fromdate = value;
            }
        }
        public DateTime ToDate
        {
            get => _todate;
            set
            {
                _todate = value;
            }
        }
        public string Fullname 
        {
            get => _fullname;
            set
            {
                _fullname = value;
            }
        }

        public Meeting(DateTime fromdate,DateTime todate,string fullname)
        {
            Fromdate = fromdate;
            ToDate = todate;
            Fullname = fullname;
        }
    }
}
