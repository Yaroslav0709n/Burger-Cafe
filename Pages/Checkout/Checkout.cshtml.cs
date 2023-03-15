using BurgerOrderApp.Data;
using BurgerOrderApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BurgerOrderApp.Pages.Checkout
{
    [BindProperties (SupportsGet = true)]
    public class CheckoutModel : PageModel
    {
        public string ForWhomBurger { get; set; }
        public double BurgerPrice { get; set; }
        readonly ApplicationDbContext context;
        public CheckoutModel(ApplicationDbContext context)
        {
            this.context = context; 
        }
        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(ForWhomBurger))
                ForWhomBurger = "Unknown";

            BurgerOrder burgerOrder = new BurgerOrder();

            burgerOrder.BurgerName = ForWhomBurger;
            burgerOrder.BurgerPrice = BurgerPrice;

            context.BurgersOrders.Add(burgerOrder);
            context.SaveChanges();
        }
    }
}
