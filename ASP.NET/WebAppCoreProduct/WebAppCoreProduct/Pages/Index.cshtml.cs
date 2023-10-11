using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace WebAppCoreProduct.Pages
{
    public class IndexModel : PageModel
    {
        //public string? MessageRezult { get; private set; }
        //public bool IsCorrect { get; set; } = true;
        //public Models.Product Product { get; set; }
        ////public void OnGet(string name, decimal? price)
        
        //{
        //    Product = new Models.Product();
        //    if (price == null || price < 0 || string.IsNullOrEmpty(name))
        //    {
        //        IsCorrect = false;
        //        return;
        //    }
        //    Product.Price = price;
        //    Product.Name = name;
        //    var result = price * (decimal?)0.18;
        //    MessageRezult = $"Для товара {name} с ценой {price} скидка получится {result}";
        //}

        //public void OnPost(string name, decimal? price)
        //{
        //    Product = new Models.Product();
        //    if (price == null || price < 0 || string.IsNullOrEmpty(name))
        //    {
        //        MessageRezult = "Переданы некорректные данные. Повторите ввод";
        //    return;
        //    }
        //    var result = price * (decimal?)0.18;
        //    MessageRezult = $"Для товара {name} с ценой {price} скидка получится {result}";
        //    Product.Price = price;
        //    Product.Name = name;
        //}
        //public void OnGet()
        //{
        //    MessageRezult = "Для товара можно определить скидку";
        //}

        public void OnGet()
        {
            
        }


    }


}
