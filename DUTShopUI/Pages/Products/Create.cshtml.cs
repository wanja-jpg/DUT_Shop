using DUTShopLibrary;
using DUTShopLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DUTShopUI.Pages.Products
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public ProductModel Product { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                Config.Connection.Product_Create(Product);
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }
    }
}
