using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class Time
    {
        private int hour;
        private int minute;
        private int second;

        public Time()
        {
            this.Hour = 0;
            this.Minute = 0;
            this.Second = 0;
        }

        public Time(long elapseTime)
        {
            TimeSpan ts = new TimeSpan(elapseTime * 1000000);
            this.Hour = ts.Hours;
            this.Minute = ts.Minutes;
            this.Second = ts.Seconds;
        }

        public int Hour {
            get
            {
                return this.hour;
            }
            set
            {
                if (value > 0)
                {
                    this.hour = value;
                }
            }
        }

        public int Minute
        {
            get
            {
                return this.minute;
            }
            set
            {
                if (value > 0)
                {
                    this.minute = value;
                }
            }
        }

        public int Second
        {
            get
            {
                return this.second;
            }
            set
            {
                if (value > 0)
                {
                    this.second = value;
                }
            }
        }

        public int GetHour()
        {
            return this.Hour;
        }

        public int GetMinute()
        {
            return this.Minute;
        }

        public int GetSecond()
        {
            return this.Second;
        }
    }
}
