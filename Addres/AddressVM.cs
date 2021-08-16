using DeliveryKing.Core.ViewModel;

namespace DeliveryKing.ViewModel.Addres
{
    public record AddressVM : BaseVM
    {
        public string Name { get; set; }
        public string Text { get; set; }
        public string Coordinates { get; set; }
    }
}