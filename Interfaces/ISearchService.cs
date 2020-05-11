using FW.Marketplace.ViewModel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FW.Marketplace.Interfaces
{
    public interface ISearchService
    {
        ValueTask<IEnumerable<ProductViewModel>> SearchByQueryAsync(string query, int page, int size);
    }
}
