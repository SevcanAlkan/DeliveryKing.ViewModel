using DeliveryKing.Core.ViewModel;
using System.ComponentModel.DataAnnotations;

namespace DeliveryKing.ViewModel.Message
{
    public record MessageUpdateVM : UpdateVM
    {
        [Required]
        [MinLength(5)]
        [MaxLength(500)]
        public string Text { get; set; }
    }
}
