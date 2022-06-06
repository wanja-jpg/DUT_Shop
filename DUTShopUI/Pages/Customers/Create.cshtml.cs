using DUTShopLibrary;
using DUTShopLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DUTShopUI.Pages.Customers
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public CustomerModel Customer { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                Config.Connection.Customer_Create(Customer);
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }
    }
}
