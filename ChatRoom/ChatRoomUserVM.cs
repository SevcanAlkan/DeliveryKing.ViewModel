using DeliveryKing.Core.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DeliveryKing.ViewModel.ChatRoom
{
    public record ChatRoomUserVM : BaseVM
    {
        public Guid UserId { get; set; }
        public Guid ChatRoomId { get; set; }
    }
}
