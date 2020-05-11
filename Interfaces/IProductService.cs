using FW.Marketplace.Model;
using FW.Marketplace.ViewModel;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FW.Marketplace.Interfaces
{
    public interface IProductService
    {
        ValueTask<IEnumerable<ProductViewModel>> GetAsync();
        ValueTask<ProductViewModel> GetByIdAsync(Guid id);
        ValueTask<ProductViewModel> GetByUserIdAsync(Guid userId);
        ValueTask<ProductViewModel> CreateAsync(ProductViewModel model);
        Task UpdateAsync(Guid id, ProductViewModel model);
        Task DeleteAsync(Guid id);
    }
}
