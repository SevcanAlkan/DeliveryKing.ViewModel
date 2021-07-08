using DeliveryKing.Core.Validation;
using DeliveryKing.Core.ViewModel;
using System;
using System.ComponentModel.DataAnnotations;

namespace DeliveryKing.ViewModel.ChatRoom
{
    public record ChatRoomUserUpdateVM : UpdateVM
    {
        [Required]
        [GuidValidation]
        public Guid UserId { get; set; }
        [Required]
        [GuidValidation]
        public Guid ChatRoomId { get; set; }
    }
}
