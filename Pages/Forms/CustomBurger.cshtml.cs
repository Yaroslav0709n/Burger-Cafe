using BurgerOrderApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BurgerOrderApp.Pages.Forms
{
    public class CustomBurgerModel : PageModel
    {
        [BindProperty]
        public BurgersModel Burgers { get; set; }
        public double BurgerPrice { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            BurgerPrice = Burgers.BurgerPrice;
            if (Burgers.BeefMince)
                BurgerPrice += 5;
            if (Burgers.LeanBeefMince)
                BurgerPrice += 7;
            if (Burgers.Mushrooms)
                BurgerPrice += 2;
            if (Burgers.Onions)
                BurgerPrice += 1.5;
            if (Burgers.Pineapple)
                BurgerPrice += 3;
            if (Burgers.Rosemary)
                BurgerPrice += 1;
            if (Burgers.Tomatoes)
                BurgerPrice += 2;
            if (Burgers.Cucumbers)
                BurgerPrice += 2;
            if (Burgers.CheeseCheader)
                BurgerPrice += 2.5;
            if (Burgers.CheeseFeta)
                BurgerPrice += 3.25;
            if (Burgers.CheeseMozzarella)
                BurgerPrice += 4;
            if (Burgers.BBQSauce)
                BurgerPrice += 1;
            if (Burgers.TomatoSauce)
                BurgerPrice += 1;
            if (Burgers.GreenPestoSauce)
                BurgerPrice += 2.75;
            return RedirectToPage("/Checkout/Checkout", new {BurgerPrice, Burgers.ForWhomBurger});
        }
    }
}
