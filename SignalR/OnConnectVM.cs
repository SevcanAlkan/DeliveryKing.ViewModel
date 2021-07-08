﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using DeliveryKing.Core.ViewModel;

namespace DeliveryKing.ViewModel.SignalR
{
    public record OnConnectVM
    {
        public Guid UserId { get; set; }
    }
}
