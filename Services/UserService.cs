using FW.Marketplace.Interfaces;
using FW.Marketplace.ViewModel;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FW.Marketplace.Services
{
    public class UserService : IUserService
    {
        public ValueTask<UserViewModel> CreateAsync(CreateUserViewModel model)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public ValueTask<IEnumerable<UserViewModel>> GetAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<UserViewModel> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Guid id, UserViewModel model)
        {
            throw new NotImplementedException();
        }

        public Task UpdatePasswordAsync(Guid id, string newpassword)
        {
            throw new NotImplementedException();
        }
    }
}
