using FW.Marketplace.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FW.Marketplace.Interfaces
{
    public interface IUserService
    {
        ValueTask<IEnumerable<UserViewModel>> GetAsync();
        ValueTask<UserViewModel> GetByIdAsync(Guid id);
        ValueTask<UserViewModel> CreateAsync(CreateUserViewModel model);
        Task UpdateAsync(Guid id, UserViewModel model);
        Task DeleteAsync(Guid id);

        Task UpdatePasswordAsync(Guid id, string newpassword);
    }
}
