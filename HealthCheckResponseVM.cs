using System;
using System.Collections.Generic;
using System.Text;

namespace DeliveryKing.ViewModel
{
    public record HealthCheckResponseVM
    {
        public string Status { get; set; }
        public IEnumerable<HealthCheckVM> Checks { get; set; }
        public TimeSpan Duration { get; set; }
    }
}
