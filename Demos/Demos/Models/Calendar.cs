using System;
using System.Collections.Generic;
using System.Text;

namespace Demos.Models
{
    public class Calendar
    {
        public int Id { get; set; }
        public string YearName { get; set; }
        public List<CalendarMonth> CalendarMonths {get;set;}
    }
}
