using System;
using System.Collections.Generic;
using System.Text;

namespace Demos.Models
{
    public class CalendarMonth
    {
        public int Id { get; set; }
        public string MonthName { get; set; }
        public List<CalendarWeek> CalendarWeek { get; set; }
    }
}
