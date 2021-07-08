using DeliveryKing.Core.Validation;
using DeliveryKing.Core.ViewModel;
using System;
using System.ComponentModel.DataAnnotations;

namespace DeliveryKing.ViewModel.Message
{
    public record MessageAddVM : AddVM
    {
        [Required]
        [MinLength(5)]
        [MaxLength(500)]
        public string Text { get; set; }
        [Required]
        [GuidValidation]
        public Guid ChatRoomId { get; set; }
    }
}
