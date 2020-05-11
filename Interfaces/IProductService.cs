using FW.Marketplace.Model;
using FW.Marketplace.ViewModel;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FW.Marketplace.Interfaces
{
    //Efetua a comunicação e o processamento da sua requisição com a fonte de dados.
    // -> O que são Services
    // -> Importancia das interfaces
    // -> Como colocar no D.I
    // -> Controllers x Services
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
