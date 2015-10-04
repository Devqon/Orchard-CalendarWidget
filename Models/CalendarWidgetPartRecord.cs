﻿using Orchard.ContentManagement.Records;

namespace DQ.Scheduling.Models
{
    public class CalendarWidgetPartRecord : ContentPartRecord
    {
        public virtual int QueryId { get; set; }
        public virtual string Plugin { get; set; }
    }
}