using NodaTime;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace TaxLibrary.datatypes
{
    class Time
    {
        private static readonly CultureInfo DEFAULT_CULTURE_INFO = CultureInfo.DefaultThreadCurrentCulture;
        public static readonly string DEFAULT_TIME_FORMAT = "HH:mm:ss";

        private LocalTime value;


        public Time(LocalTime time)
        {
            this.value = time;
        }

        public static Time Now()
        {
            return new Time(LocalDateTime.FromDateTime(System.DateTime.Now).TimeOfDay);
        }

        public string ToFormattedString(CultureInfo cultureInfo)
        {
            return (cultureInfo == null ? DEFAULT_CULTURE_INFO : cultureInfo).DateTimeFormat.ShortTimePattern;
        }

        public int CompareTo(Time other)
        {
            return value.CompareTo(other.value);
        }

        public LocalTime ToLocalTime()
        {
            return value;
        }

        public Time Plus(long amountToAdd, PeriodUnits unit)
        {
            if (PeriodUnits.Hours.Equals(unit))
                this.value.Plus(Period.FromHours(amountToAdd));
            if (PeriodUnits.Minutes.Equals(unit))
                this.value.Plus(Period.FromMinutes(amountToAdd));
            if (PeriodUnits.Seconds.Equals(unit))
                this.value.Plus(Period.FromSeconds(amountToAdd));
            return this;
        }

        public Time Minus(long amountToRemove, PeriodUnits unit)
        {
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
            return value != null ? value.ToString(DEFAULT_TIME_FORMAT, DEFAULT_CULTURE_INFO) : " ";
        }

        public override bool Equals(object other)
        {
            if((other == null) || !(other is Time))
            {
                return false;
            }
            LocalTime otherValue = ((Time)other).value;
            return value.Equals(otherValue);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(value);
        }



    }
}
