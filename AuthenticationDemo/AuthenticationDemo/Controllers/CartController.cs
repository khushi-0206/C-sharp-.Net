using AuthenticationDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace AuthenticationDemo.Controllers
{
    public class CartController : Controller
    {
        ProductRepo repo = new ProductRepo();

        public IActionResult Index()
        {
            return View(CartStorage.CartItems);
        }
        //CartItems is a static list in Cart Storage
        public IActionResult Add(int id)
        {
            //find the product in GetAllCosmeticProducts
            var product = repo.GetAllCosmeticProducts().FirstOrDefault(p => p.ProductId == id);

            //check if the product is in the cart or not by using first or fefault it exict increase the quantitty
            var exist = CartStorage.CartItems.FirstOrDefault(c => c.Product.ProductId == id);

            if (exist != null)
                exist.Quantity++;
            else
                CartStorage.CartItems.Add(new CartItem
                {
                    Product = product,
                    Quantity = 1
                });

            return RedirectToAction("Index1", "Product");  //return to the main page
        }

        public IActionResult Increase(int id)
        {
            var product = CartStorage.CartItems.FirstOrDefault(c => c.Product.ProductId == id);

            if (product != null)
                product.Quantity++;

            return RedirectToAction("Index");
        }

        public IActionResult Decrease(int id)
        {
            var product = CartStorage.CartItems.FirstOrDefault(c => c.Product.ProductId == id);

            if (product != null)
            {
                product.Quantity--;

                if (product.Quantity <= 0)
                    CartStorage.CartItems.Remove(product);
            }

            return RedirectToAction("Index");
        }
    }
}
