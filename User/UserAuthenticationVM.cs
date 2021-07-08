using DeliveryKing.Core.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using DeliveryKing.ViewModel.Auth;

namespace DeliveryKing.ViewModel.User
{
    public record UserAuthenticationVM : BaseVM
    {
        public string UserName { get; set; }
        public string DisplayName { get; set; }
        public string About { get; set; }

        public TokenCacheVM TokenData { get; set; }
    }
}
