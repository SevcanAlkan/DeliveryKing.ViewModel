using System;
using System.ComponentModel.DataAnnotations;
using DeliveryKing.Core;

namespace DeliveryKing.ViewModel.Auth.ViewModel
{
    public record TokenRefreshRequestVM
    {
        [Required(ErrorMessage= APIStatusCode.ERR03001)]
        public string AccessToken { get; set; }

        [Required(ErrorMessage= APIStatusCode.ERR03001)]
        public string RefreshToken { get; set; }
    }
}
