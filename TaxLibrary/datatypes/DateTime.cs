using NodaTime;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace TaxLibrary.datatypes
{
    class DateTime
    {
        private static readonly CultureInfo DEFAULT_CULTURE_INFO = CultureInfo.DefaultThreadCurrentCulture;
        public static readonly string DEFAULT_DATETIME_FORMAT = Date.DEFAULT_DATE_FORMAT + " " + Time.DEFAULT_TIME_FORMAT;

        private LocalDateTime value;

        public DateTime(LocalDateTime dateTime)
        {
            this.value = dateTime;
        }

        public DateTime(System.DateTime dateTime)
        {
            this.value = LocalDateTime.FromDateTime(dateTime);
        }

        public DateTime()
        {
            this.value = LocalDateTime.FromDateTime(System.DateTime.Now);
        }


        public static DateTime Of(Date date, Time time)
        {
            return new DateTime(date.ToLocalDate().At(time.ToLocalTime()));
        }

        public static DateTime Of(Date date)
        {
            return new DateTime(date.ToLocalDate().At(LocalDateTime.FromDateTime(System.DateTime.Now).TimeOfDay));
        }

        public static DateTime Of(LocalDateTime date)
        {
            return new DateTime(date);
        }
        public static DateTime Of(System.DateTime date)
        {
            return new DateTime(date);
        }

        public static DateTime Of(DateTime date)
        {
            return new DateTime(date.ToLocalDateTime());
        }

        public static DateTime Now()
        {
            return new DateTime(System.DateTime.Now);
        }

        public int Year { get => value.Year; }
        public int Month { get => value.Month; }
        public int Day { get => value.Day; }
        public int Hour { get => value.Hour; }
        public int Minute { get => value.Minute; }
        public int Secund { get => value.Second; }
        public int MilliSecund { get => value.Millisecond; }

        public Time ToTime()
        {
            return this.value != null ? new Time(this.value.TimeOfDay) : null;
        }

        public Date ToDate()
        {
            return this.value != null ? new Date(this.value.Date) : null;
        }

        public LocalDateTime ToLocalDateTime()
        {
            return value;
        }

        public System.DateTime ToSystemDateTime()
        {
            return value.ToDateTimeUnspecified();
        }

        public int CompareTo(DateTime other)
        {
            return this.value.CompareTo(other.value);
        }

        public int CompareTo(Date other)
        {
            if (Year != other.Year)
            {
                return Year < other.Year ? -1 : 1;
            }
            if (Month != other.Month)
            {
                return Month < other.Month ? -1 : 1;
            }
            if (Day != other.Day)
            {
                return Day < other.Day ? -1 : 1;
            }
            return 0;
        }

        public int CompareTo(System.DateTime other)
        {
            if (Year != other.Year)
            {
                return Year < other.Year ? -1 : 1;
            }
            if (Month != other.Month)
            {
                return Month < other.Month ? -1 : 1;
            }
            if (Day != other.Day)
            {
                return Day < other.Day ? -1 : 1;
            }
            return 0;
        }

        public bool IsSameDateAs(DateTime other)
        {
            if (Year != other.Year)
            {
                return false;
            }
            if (Month != other.Month)
            {
                return false;
            }
            if (Day != other.Day)
            {
                return false;
            }
            return true;
        }

        public bool IsSameDateAs(Date other)
        {
            if (Year != other.Year)
            {
                return false;
            }
            if (Month != other.Month)
            {
                return false;
            }
            if (Day != other.Day)
            {
                return false;
            }
            return true;
        }

        public bool IsSameDateAs(System.DateTime other)
        {
            if (Year != other.Year)
            {
                return false;
            }
            if (Month != other.Month)
            {
                return false;
            }
            if (Day != other.Day)
            {
                return false;
            }
            return true;
        }

        public DateTime Plus(long amountToAdd, PeriodUnits unit)
        {
            if (PeriodUnits.Years.Equals(unit))
                this.value.Plus(Period.FromYears(Int32.Parse(amountToAdd.ToString())));
            if (PeriodUnits.Months.Equals(unit))
                this.value.Plus(Period.FromMonths(Int32.Parse(amountToAdd.ToString())));
            if (PeriodUnits.Days.Equals(unit))
                this.value.Plus(Period.FromDays(Int32.Parse(amountToAdd.ToString())));
            if (PeriodUnits.Hours.Equals(unit))
                this.value.Plus(Period.FromHours(amountToAdd));
            if (PeriodUnits.Minutes.Equals(unit))
                this.value.Plus(Period.FromMinutes(amountToAdd));
            if (PeriodUnits.Seconds.Equals(unit))
                this.value.Plus(Period.FromSeconds(amountToAdd));
            return this;
        }

        public DateTime Minus(long amountToRemove, PeriodUnits unit)
        {
            if (PeriodUnits.Years.Equals(unit))
                this.value.Minus(Period.FromYears(Int32.Parse(amountToRemove.ToString())));
            if (PeriodUnits.Months.Equals(unit))
                this.value.Minus(Period.FromMonths(Int32.Parse(amountToRemove.ToString())));
            if (PeriodUnits.Days.Equals(unit))
                this.value.Minus(Period.FromDays(Int32.Parse(amountToRemove.ToString())));
            if (PeriodUnits.Hours.Equals(unit))
                this.value.Minus(Period.FromHours(amountToRemove));
            if (PeriodUnits.Minutes.Equals(unit))
                this.value.Minus(Period.FromMinutes(amountToRemove));
            if (PeriodUnits.Seconds.Equals(unit))
                this.value.Minus(Period.FromSeconds(amountToRemove));
            return this;
        }

        public override string ToString()
        {
            return this.value != null ? value.ToString(DEFAULT_DATETIME_FORMAT, DEFAULT_CULTURE_INFO) : " ";
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(value);
        }

        public override bool Equals(object other)
        {
            if (other == null || !(other is DateTime))
                return false;
            LocalDateTime otherValue = ((DateTime)other).value;
            return value.Equals(otherValue);
        }




    }
}
