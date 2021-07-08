using System;

namespace DeliveryKing.ViewModel.SignalR
{
    public record OnJoinToGroup
    {
        public string ConnectionId { get; set; }
    }
}
