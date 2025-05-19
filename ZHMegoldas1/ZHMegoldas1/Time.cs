using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZHMegoldas1
{
    public class Time
    {
        private int Hour;
        private int Minute;
        private int Second;

        public int GetHour()
        {
            return Hour;
        }
        public int GetMinute()
        {
            return Hour;
        }
        public int GetSecond()
        {
            return Hour;
        }
        public void SetHour(int hour) 
        {
            if(hour >= 0 && hour<=3)
            {

                Hour = hour;
            }
            else
            {
                throw new TimeException("Rossz Óra");
            }
        }
        public void SetMinute(int minute) 
        {
            if (minute >= 0 && minute <= 59)
            {

                Minute = minute;
            }
            else
            {
                throw new TimeException("Rossz Perc");
            }
        }
        public void SetSecond(int second) 
        {
            if (second >= 0 && second <= 59)
            {

                Second = second;
            }
            else
            {
                throw new TimeException("Rossz Másodperc");
            }
        }

        public Time(int hour, int minute, int second)
        {
            SetHour(hour);
            SetMinute(minute);
            SetSecond(second);
        }

        public Time(int minute, int second)
        {
            Hour = 0;
            SetMinute(minute);
            SetSecond(second);
        }

        public override string? ToString()
        {
            string szoveg;
            if(Hour == 0)
            {
                szoveg= Minute.ToString().PadLeft(2, '0')+":"+Second.ToString().PadLeft(2, '0');
            }
            else
            {
                szoveg = Hour.ToString().PadLeft(2,'0')+":"+Minute.ToString().PadLeft(2, '0') + ":" + Second.ToString().PadLeft(2, '0');
            }
            return base.ToString();
        }
        public static Time TimeParse(string input)
        {
            if (input == "??:??:??" && input=="??:??")
            {
                string[] times = input.Split(':');
                if(times.Length == 2) 
                {
                    Time time = new Time(int.Parse(times[0]), int.Parse(times[1]));
                    return time;
                }
                else
                {
                    Time time = new Time(int.Parse(times[0]), int.Parse(times[1]), int.Parse(times[2]));
                    return time;

                }
            }
            else
            {
                throw new TimeException("Rossz formátum");
            }
        }
    }
}
