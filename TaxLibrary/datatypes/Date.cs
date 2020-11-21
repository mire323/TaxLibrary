using NodaTime;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;


namespace TaxLibrary.datatypes
{
    class Date
    {
        private static readonly CultureInfo DEFAULT_CULTURE_INFO = CultureInfo.DefaultThreadCurrentCulture;
        public static readonly string DEFAULT_DATE_FORMAT = "dd-MM-yyyy";


        private LocalDate value;

        public Date(LocalDate date)
        {
            this.value = date;
        }

        public Date(System.DateTime date)
        {
            this.value = LocalDate.FromDateTime(date);
        }

        public static Date Now()
        {
            return new Date(System.DateTime.Now);
        }

        public string ToFormattedString(CultureInfo cultureInfo)
        {
            return (cultureInfo == null ? DEFAULT_CULTURE_INFO : cultureInfo).DateTimeFormat.ShortDatePattern;
        }

        public LocalDate ToLocalDate()
        {
            return value;
        }

        public int Year { get => value.Year; }
        public int Month { get => value.Month; }
        public int Day { get => value.Day; }

        public int CompareTo(Date other)
        {
            return value.CompareTo(other.value);
        }

        public int CompareTo(DateTime other)
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

        public int CompareTo(LocalDate other)
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

        public bool IsSameDateAs(LocalDate other)
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

        public Date Plus(int amountToAdd, PeriodUnits unit)
        {
            if (PeriodUnits.Years.Equals(unit))
                this.value.Plus(Period.FromYears(amountToAdd));
            if (PeriodUnits.Months.Equals(unit))
                this.value.Plus(Period.FromMonths(amountToAdd));
            if (PeriodUnits.Days.Equals(unit))
                this.value.Plus(Period.FromDays(amountToAdd));
            return this;
        }

        public Date Minus(int amountToRemove, PeriodUnits unit)
        {
            if (PeriodUnits.Years.Equals(unit))
                this.value.Minus(Period.FromYears(amountToRemove));
            if (PeriodUnits.Months.Equals(unit))
                this.value.Minus(Period.FromMonths(amountToRemove));
            if (PeriodUnits.Days.Equals(unit))
                this.value.Minus(Period.FromDays(amountToRemove));
            return this;
        }

        public override string ToString()
        {
            return value != null ? value.ToString(DEFAULT_DATE_FORMAT, DEFAULT_CULTURE_INFO) : " ";
        }

        public override bool Equals(object other)
        {
            if (other == null || !(other is Date))
            {
                return false;
            }
            LocalDate otherValue = ((Date)other).value;
            return value.Equals(otherValue);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(value);
        }
    }
}
