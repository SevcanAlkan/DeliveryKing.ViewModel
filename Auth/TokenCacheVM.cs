using System;
using System.Collections.Generic;
using System.Text;
using DeliveryKing.Core.ViewModel;

namespace DeliveryKing.ViewModel.Auth
{
    public record TokenCacheVM : BaseVM
    {
        public string AccessToken { get; set; }
        public DateTime AccessTokenExpiryTime { get; set; }

        public string RefreshToken { get; set; }
        public DateTime RefreshTokenExpiryTime { get; set; }
    }
}
