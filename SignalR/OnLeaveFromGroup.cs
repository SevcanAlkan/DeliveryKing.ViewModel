using System;

namespace DeliveryKing.ViewModel.SignalR
{
    public record OnLeaveFromGroup
    {
        public string ConnectionId { get; set; }
    }
}
