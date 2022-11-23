using System;

namespace ConsoleApplication6
{
    public class Time
    {
        private int hour;
        private int minute;
        private int second;

        public int Hour  // свойство
        {
            get
            {
                return hour;
            }
            set
            {
                if (hour>=24)
                    throw new ArgumentException("hours value can not be greater than 24");
                hour = value;
            }
        }
        public int Minute  // свойство
        {
            get
            {
                return minute;
            }
            set
            {
                if (minute>=60)
                    throw new ArgumentException("hours value can not be greater than 60");
                minute = value;            }
        }
        public int Second  // свойство
        {
            get
            {
                return second;
            }
            set
            {
                if (hour>=60)
                    throw new ArgumentException("second value can not be greater than 60");
                second = value;            
            }
        }
        public Time(int a, int b, int c) //конструктор 
        {
            Hour = a;//
            Minute = b;
            Second = c;
        }

        public int InSeconds()
        {
            return Hour * 60 * 60 + Minute * 60 + Second;
        }

        public override string ToString()
        {
            return
                $"{string.Format("{0:d2}", Hour)}:{string.Format("{0:d2}", Minute)}:{string.Format("{0:d2}", Second)}";
        }

        public static Time operator +(Time f1, Time f2)
        {
            //
            var sum = f1.InSeconds() + f2.InSeconds();
            var hour = sum / 3600;
            var minute = sum % 3600 / 60;
            var second = sum % 3600 % 60;  
            return new Time(hour, minute, second);
        }
        public static Time operator -(Time f1, Time f2)
        {
            //
            var sum = f1.InSeconds() - f2.InSeconds();
            var hour = sum / 3600;
            var minute = sum % 3600 / 60;
            var second = sum % 3600 % 60;  
            return new Time(hour, minute, second);
        }

        public static Time operator *(Time f1, int a)
        {
            var sum = f1.InSeconds() * a;
            var hour = sum / 3600;
            var minute = sum % 3600 / 60;
            var second = sum % 3600 % 60;  
            return new Time(hour, minute, second);
        }
        public static Time operator /(Time f1, int a)
        {
            var sum = f1.InSeconds() / a;
            var hour = sum / 3600;
            var minute = sum % 3600 / 60;
            var second = sum % 3600 % 60;  
            return new Time(hour, minute, second);
        }
        
    }
}