using BurgerOrderApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BurgerOrderApp.Pages
{
    public class BurgerModel : PageModel
    {
        public List<BurgersModel> BurgerDB = new List<BurgersModel>()
        {
            new BurgersModel(){BurgerImage = "https://www.california-republic.com.ua/image/catalog/burger/basic-min.JPG?v=1626249838",ForWhomBurger = "Classic Burger",BurgerPrice = 4,},
            new BurgersModel(){BurgerImage = "https://www.california-republic.com.ua/image/catalog/burger/cali.jpg?v=1678743452", ForWhomBurger="Californication Burger", BurgerPrice = 6,},
            new BurgersModel(){BurgerImage = "https://www.california-republic.com.ua/image/catalog/burger/_7777.webp?v=1617096025", ForWhomBurger = "Club House Burger", BurgerPrice = 4},
            new BurgersModel(){BurgerImage = "https://www.california-republic.com.ua/image/catalog/burger/Double%20Trouble.png?v=1620898011", ForWhomBurger = "Double Trouble Burger", BurgerPrice = 7},
            new BurgersModel(){BurgerImage = "https://www.california-republic.com.ua/image/catalog/burger/forrest.jpg?v=1634155357", ForWhomBurger= "Forrest Gamp Burger", BurgerPrice = 6},
            new BurgersModel(){BurgerImage = "https://www.california-republic.com.ua/image/catalog/burger/oktavian-min.JPG?v=1626249649", ForWhomBurger = "Oktavian Burger", BurgerPrice = 9},
            new BurgersModel(){BurgerImage = "https://www.california-republic.com.ua/image/catalog/burger/tihyana.jpg?v=1662977194", ForWhomBurger = "Tihyana Burger", BurgerPrice = 7},
            new BurgersModel(){BurgerImage = "https://www.california-republic.com.ua/image/catalog/burger/2.webp?v=1617096025", ForWhomBurger = "Neapol Burger", BurgerPrice = 5},
        };

        public void OnGet()
        {
        }
    }
}
