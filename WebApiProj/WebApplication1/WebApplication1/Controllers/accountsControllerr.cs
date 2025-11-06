using BusinessLogic;
using InventoryCommon;
using Microsoft.AspNetCore.Mvc;

namespace inventoryApi.Controllers
{
    public class accountsControllerr : Controller
    {
        private readonly inventoryProcess inventoryProcess;

        public accountsControllerr(inventoryProcess _inventoryProcess)
        {
            inventoryProcess = _inventoryProcess;
        }

        // GET /accountsControllerr
        [HttpGet]
        public List<Accounts> GetAccounts()
        {
            return inventoryProcess.getAccounts();
        }

        // POST /accountsControllerr/check
        [HttpPost("check")]
        public bool CheckAccount([FromBody] Accounts account)
        {
            return inventoryProcess.accountExist(account.userName, account.password);
        }

        // POST /accountsControllerr/add
        [HttpPost("add")]
        public void AddAccount([FromBody] Accounts account)
        {
            inventoryProcess.addAccount(account.userName, account.password);
        }


    }
}
