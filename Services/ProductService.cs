using FW.Marketplace.Interfaces;
using FW.Marketplace.ViewModel;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FW.Marketplace.Services
{
    public class ProductService : IProductService
    {
        public ValueTask<ProductViewModel> CreateAsync(ProductViewModel model)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public ValueTask<IEnumerable<ProductViewModel>> GetAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<ProductViewModel> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public ValueTask<ProductViewModel> GetByUserIdAsync(Guid userId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Guid id, ProductViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}
