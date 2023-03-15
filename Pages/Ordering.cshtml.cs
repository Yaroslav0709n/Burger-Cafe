using BurgerOrderApp.Data;
using BurgerOrderApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BurgerOrderApp.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        public List<BurgerOrder> burgerOrders = new List<BurgerOrder>();
        readonly ApplicationDbContext context;
        public PrivacyModel(ApplicationDbContext context)
        {
            this.context = context;
        }
        public void OnGet()
        {
            burgerOrders = context.BurgersOrders.ToList();
        }
    }
}