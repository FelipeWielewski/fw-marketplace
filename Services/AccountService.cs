using FW.Marketplace.Interfaces;
using FW.Marketplace.ViewModel;
using System;
using System.Threading.Tasks;

namespace FW.Marketplace.Services
{
    public class AccountService : IAccountService
    {
        public ValueTask<bool> LoginAsync(LoginViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}
