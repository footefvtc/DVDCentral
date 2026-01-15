using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using BDF.DVDCentral.BL.Models;
using BDF.DVDCentral.UI.Models;
using BDF.DVDCentral.UI.ViewModels;
using System.Collections.Generic;

namespace BDF.DVDCentral.UI.Controllers
{
    public class ShoppingCartController : Controller
    {
        ShoppingCart cart;

        // GET: ShoppingCartController
        public IActionResult Index()
        {
            ViewBag.Title = "Shopping Cart";
            cart = GetShoppingCart();
            return View(cart);
        }

        private ShoppingCart GetShoppingCart()
        {
            if (HttpContext.Session.GetObject<ShoppingCart>("cart") != null)
            {
                return HttpContext.Session.GetObject<ShoppingCart>("cart");
            }
            else
            {
                return new ShoppingCart();
            }
        }

        public IActionResult Remove(int id)
        {
            cart = GetShoppingCart();
            Movie movie = cart.Items.FirstOrDefault(i => i.Id == id);
            ShoppingCartManager.Remove(cart, movie);
            HttpContext.Session.SetObject("cart", cart);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Add(int id)
        {
            cart = GetShoppingCart();
            Movie movie = MovieManager.LoadById(id);
            ShoppingCartManager.Add(cart, movie);
            HttpContext.Session.SetObject("cart", cart);
            return RedirectToAction(nameof(Index), "Movie");
        }

        public IActionResult Checkout()
        {
            if (Authenticate.IsAuthenticated(HttpContext))
            {
                //int orderId = 1;
                ViewBag.Title = "Checkout";
                //cart = GetShoppingCart();
                //ShoppingCartManager.Checkout(cart, ref orderId);
                //HttpContext.Session.SetObject("cart", null);
                return RedirectToAction(nameof(AssignToCustomer));
            }
            else
            {
                return RedirectToAction("Login", "User", new { returnUrl = UriHelper.GetDisplayUrl(HttpContext.Request) });
            }
        }

        public IActionResult AssignToCustomer()
        {
            ViewBag.Title = "Assign to a Customer";

            // Get the user from Session
            int userId = HttpContext.Session.GetObject<int>("userID");

            // Instantiate a new instance of the CustomerViewModel view model
            CustomerVM customerVM = new CustomerVM();

            // Instantiate a new instance of Customer object 
            Customer customer = new Customer();

            // Get and put the cart into the ViewModel
            cart = GetShoppingCart();
            customerVM.Cart = cart;

            // Load ViewModel.Customers list
            customerVM.Customers = CustomerManager.Load();

            // Set the userId in the ViewModel
            customerVM.UserId = userId;

            // if the UserId has any customers, set the ViewModel.CustomerId to the first one. Could have more than one.
            if(customerVM.Customers.FirstOrDefault(c => c.UserId == customerVM.UserId) != null)
            {
                customerVM.CustomerId = customerVM.Customers.FirstOrDefault(c => c.UserId == customerVM.UserId).Id;
            }

            // Put the ViewModel in session
            HttpContext.Session.SetObject("customerVM", customerVM);

            // Set the ViewData["ReturnUrl"] to the UriHelper.GetDisplayUrl(HttpContext.Request);
            ViewData["ReturnUrl"] = UriHelper.GetDisplayUrl(HttpContext.Request);

            // return the view with ViewModel as the model 
            return View(customerVM);
        }

        [HttpPost]
        public IActionResult AssignToCustomer(CustomerVM customerVM)
        {
            try
            {
                // Get and assign the ViewModel.Cart
                customerVM.Cart = GetShoppingCart();
                customerVM.Cart.CustomerId = customerVM.CustomerId;
                customerVM.Cart.UserId = customerVM.UserId;

                // Add the Order like you did in the Checkout Method
                int orderId = 1;
                ShoppingCartManager.Checkout(customerVM.Cart, ref orderId);

                // Clear the Shopping cart
                HttpContext.Session.SetObject("cart", null);

                // Show the thank you for your order screen
                return View("Checkout");
            }
            catch (Exception ex)
            {
                ViewBag.Title = "Assign to a Customer";
                ViewBag.Error = ex.Message;
                return View();
            }
        }
    }
}
