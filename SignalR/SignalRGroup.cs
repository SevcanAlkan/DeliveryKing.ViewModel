﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using DeliveryKing.Core.ViewModel;

namespace DeliveryKing.ViewModel.SignalR
{
    public record SignalRGroup : BaseVM<string>
    {
        public List<Guid> ConnectedUsers { get; set; }
    }
}
