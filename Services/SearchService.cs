using FW.Marketplace.Interfaces;
using FW.Marketplace.ViewModel;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FW.Marketplace.Services
{
    public class SearchService : ISearchService
    {
        public ValueTask<IEnumerable<ProductViewModel>> SearchByQueryAsync(string query, int page, int size)
        {
            throw new NotImplementedException();
        }
    }
}
