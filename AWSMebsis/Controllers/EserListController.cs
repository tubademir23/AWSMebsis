using AWSMebsis.Models;
using AWSMebsis.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AWSMebsis.Controllers
{
    [Route("v1/eserList")]
    public class EserListController : Controller
    {
        private readonly IEserListService _eserListService;

        public EserListController(IEserListService eserListService)
        {
            _eserListService = eserListService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var result = _eserListService.GetItemsFromEserList();

            return Ok(result);
        }
        [HttpPost]
        public IActionResult AddItemToEserList([FromBody] EserListModel eserList) 
        {
            _eserListService.AddItemToEserList(eserList);
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteItemFromEserList([FromBody] EserListModel eserList)
        {
            _eserListService.RemoveItem(eserList.Adi);
            return Ok();
        }
    }
}
