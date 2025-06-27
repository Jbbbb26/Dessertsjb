using DessertCommon;
using DessertPurchasingLogic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DessertShopAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class purchasedController : ControllerBase
    {
        DessertPurchasingLogic.PurchasingProcess process = new DessertPurchasingLogic.PurchasingProcess();

        [HttpGet]
        public IEnumerable<PurchaseRecord> GetPurchased()
        {
            var purchase = process.GetAllPurchases();

            return purchase;
        }
        [HttpPost]
        public void addPurchased(string userName, int flavors, int quantity, int price, int subTotal)
        {
             process.purchasedItem(userName, flavors, quantity, price, subTotal);
        }


    }
}