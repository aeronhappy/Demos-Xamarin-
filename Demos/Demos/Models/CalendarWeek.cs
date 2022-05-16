using System;
using System.Collections.Generic;
using System.Text;

namespace Demos.Models
{
    public class CalendarWeek
    {
        public int Id { get; set; }
        public string WeekName { get; set; }
        public List<CalendarDay> CalendarDays { get; set; }
    }
}
