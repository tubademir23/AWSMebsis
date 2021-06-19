using AWSMebsis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AWSMebsis.Services
{

    public interface IEserListService
    {
        public Dictionary<string, int> GetItemsFromEserList();
        public void AddItemToEserList(EserListModel eserList);
        public void RemoveItem(string adi);
    }
}
