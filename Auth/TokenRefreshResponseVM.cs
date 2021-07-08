using System;
using System.ComponentModel.DataAnnotations;
using DeliveryKing.Core;

namespace DeliveryKing.ViewModel.Auth.ViewModel
{
    public record TokenRefreshResponseVM
    {
        public string AccessToken { get; set; }
        public DateTime AccessTokenExpiryTime { get; set; }
        public string RefreshToken { get; set; }
        public DateTime RefreshTokenExpiryTime { get; set; }
    }
}
