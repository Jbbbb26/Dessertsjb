using DessertCommon;
using DessertPurchasingLogic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DessertShopAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class accountsController : ControllerBase
    {
        DessertPurchasingLogic.PurchasingProcess purchasingprocess = new DessertPurchasingLogic.PurchasingProcess();
        [HttpGet]
        public IEnumerable<userAccounts> GetUsers()
        {

            var accounts = purchasingprocess.GetAccounts();

            return accounts;
        }
    }
}
