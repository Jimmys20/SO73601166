using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SO73601166.Models;

namespace SO73601166.Pages
{
    public class IndexModel : PageModel
    {
        private readonly List<Fruit> _fruitList = new()
        {
            new Fruit { Id = "1", Name = "Banana", Price = 200 },
            new Fruit { Id = "2", Name = "Apple", Price = 47 },
            new Fruit { Id = "3", Name = "Orange", Price = 75 },
            new Fruit { Id = "4", Name = "Lemon", Price = 123 },
        };

        [BindProperty]
        public string SelectedFruit { get; set; } = "1";

        public int? SelectedFruitPrice =>
            _fruitList.FirstOrDefault(x => x.Id == SelectedFruit)?.Price;

        public SelectList Options { get; set; }

        public void OnGet()
        {
            Options = new SelectList(_fruitList, "Id", "Name");
        }

        public void OnPost()
        {
            Options = new SelectList(_fruitList, "Id", "Name");
        }
    }
}