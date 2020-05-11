using FW.Marketplace.ViewModel;
using System.Threading.Tasks;

namespace FW.Marketplace.Interfaces
{
    public interface IAccountService
    {
        ValueTask<bool> LoginAsync(LoginViewModel model);
    }
}
