using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Calendar
{
    public class CalendarGlobalData
    {
        public const string Prev = "prev";
        public const string Next = "next";
        public static string[] WeekDays = { "sunday", "monday", "tuesday", "wednesday", "thursday", "friday", "saturday" };
        public static string[] WeekDaysLabel = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
        public static string[] MonthsLabel = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
        public const string MonthView = "monthview";
        public const string YearView = "yearview";
        public object Parent { get; set; }
        public Color SelectedDateColor { get; set; } = Color.LightBlue;
        public Color DisabledColor { get; set; } = Color.LightGray;
        public Color OldMonthDatesColor { get; set; } = Color.DarkGray;
        public Color ActivatedColor { get; set; } = (Color)Application.Current.Resources["lightAccentBackground"];
        public Color TextColor { get; set; } = Color.Black;
        public string BorderType { get; set; } = BorderType_Border;
        public string WeekEndingDay { get; set; } = "Friday";
        public string SelectedFillType { get; set; } = FillType_Fill;
        public DateTime MinDateRange { get; set; } = DateTime.MinValue;
        public string DateFormat { get; set; } = "{0:MM/dd/yyyy}" ;
        public DateTime CalendarUI_DT { get; set; } = DateTime.Now;
        public DateTime MaxDateRange { get; set; } = DateTime.MaxValue;
        public const string FillType_Fill = "fillbox";
        public const string FillType_Circle = "circle";
        public const string BorderType_Collapsed = "collapsed";
        public const string BorderType_Border = "border";
    }
}
