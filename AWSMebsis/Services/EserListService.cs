using AWSMebsis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AWSMebsis.Services
{
    public class EserListService:IEserListService
    {
        private readonly Dictionary<string, int> _eserListStorage = new Dictionary<string, int>();
        public Dictionary<string, int> GetItemsFromEserList()
        {
            return _eserListStorage;
        }
        public void AddItemToEserList(EserListModel eserList)
        {
            _eserListStorage.Add(eserList.Adi, eserList.Barcode);
        }
        public void RemoveItem(string adi)
        {
            _eserListStorage.Remove(adi);
        }
    }
}
