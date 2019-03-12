using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SoapyBusApp
{
    public interface ISoapService
    {
        Task<List<DBItem>> RefreshDataAsync ();
        Task SaveTodoItemAsync(DBItem item, bool isNewItem);

        Task DeleteTodoItemAsync(string id);

    }
}
