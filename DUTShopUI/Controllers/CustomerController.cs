using DUTShopLibrary;
using Microsoft.AspNetCore.Mvc;

namespace DUTShopUI.Controllers
{
    [Route("api/Customer")]
    [ApiController]
    public class CustomerController : Controller
    {

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {   
            if (Config.Connection.Customer_Delete(id) == true)
                //return Json(new { success = true, message = "Delete successful" });
                return RedirectToAction("Index");

            //return Json(new { success = false, message = "Error while Deleting" });
            return RedirectToAction("Index");
        }
    }
}
