using System;
using System.Collections.Generic;
using System.Text;

namespace DeliveryKing.ViewModel
{
    public record HealthCheckVM
    {
        public string Status { get; set; }
        public string Component { get; set; }
        public string Description { get; set; }
    }
}
