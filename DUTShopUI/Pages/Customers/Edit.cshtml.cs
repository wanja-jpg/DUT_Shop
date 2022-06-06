using DUTShopLibrary;
using DUTShopLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DUTShopUI.Pages.Customers
{
    public class EditModel : PageModel
    {
        [BindProperty]
        public CustomerModel Customer { get; set; }
        public void OnGet(int id)
        {
            Customer = Config.Connection.Customer_Get(id);
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                Config.Connection.Customer_Update(Customer);

                return RedirectToPage("Index");
            }
            return RedirectToPage();
        }
    }
}
