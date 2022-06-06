using DUTShopLibrary;
using DUTShopLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DUTShopUI.Pages.Products
{
    public class IndexModel : PageModel
    {
        public List<ProductModel> Products { get; set; }
        public void OnGet()
        {
            Products = Config.Connection.Products_GetAll().ToList();
        }

        public async Task<IActionResult> OnPostDelete(int id)
        {
            if (Config.Connection.Product_Delete(id) == false)
            {
                return NotFound();
            }

            return RedirectToPage("Index");
        }
    }
}
