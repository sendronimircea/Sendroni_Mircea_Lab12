using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Sendroni_Mircea_Lab12.Models;

namespace Sendroni_Mircea_Lab12.Data
{
    public class ShoppingListDatabase
    {
        IRestService restService;

        public ShoppingListDatabase(IRestService service)
        {
            restService = service;
        }

        public Task<List<ShopList>> GetShopListAsync()
        {
            return restService.RefreshDataAsync();
        }

        public Task SaveShopListAsync(ShopList item, bool IsNewItem = true)
        {
            return restService.SaveShopListAsync(item, IsNewItem);
        }

        public Task DeleteShopListAsync(ShopList item)
        {
            return restService.DeleteShopListAsync(item.ID);
        }

    }
}