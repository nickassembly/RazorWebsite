using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WiredBrainCoffee.Models;
using WiredBrainCoffee.Services;

namespace WiredBrainCoffee.Pages
{
    public class MenuModel : PageModel
    {
        private IMenuService _menuService;
        public MenuModel(IMenuService menuService)
        {
            _menuService = menuService;
        }

        public List<MenuItem> Menu { get; set; }

        public void OnGet()
        {
            Menu = _menuService.GetMenuItems();
        }
    }
}
