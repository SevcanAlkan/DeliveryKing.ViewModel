using System.ComponentModel.DataAnnotations;
using DeliveryKing.Core.ViewModel;

namespace DeliveryKing.ViewModel.Addres
{
    public record AddressUpdateVM : UpdateVM
    {
        [Required]
        [MinLength(5)]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        public string Text { get; set; }
        [Required]
        [MinLength(6)]
        [MaxLength(10)]
        public string Coordinates { get; set; }
    }
}