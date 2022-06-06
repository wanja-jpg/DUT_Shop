using DUTShopLibrary;
using DUTShopLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DUTShopUI.Pages.Customers
{
    public class IndexModel : PageModel
    {
        public List<CustomerModel> Customers { get; set; }
        public void OnGet()
        {
            Customers = Config.Connection.Customers_GetAll().ToList();
        }

        public async Task<IActionResult> OnPostDelete(int id)
        {
            if (Config.Connection.Customer_Delete(id) == false)
            {
                return NotFound();
            }

            return RedirectToPage("Index");
        }
    }
}
