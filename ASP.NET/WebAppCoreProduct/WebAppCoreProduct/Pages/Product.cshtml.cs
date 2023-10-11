using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace WebAppCoreProduct.Pages
{
    public class ProductModel : PageModel
    {
        public string? MessageRezult { get; private set; }
        public Models.Product Product { get; set; }
        
        public void OnPost(string name, decimal? price)
        {
            Product = new Models.Product();
            if (price == null || price < 0 || string.IsNullOrEmpty(name))
            {
                MessageRezult = "Переданы некорректные данные. Повторите ввод";
                return;
            }
            var result = price * (decimal?)0.18;
            MessageRezult = $"Для товара {name} с ценой {price} скидка получится {result}";
            Product.Price = price;
            Product.Name = name;
        }
        public void OnGet()
        {
            MessageRezult = "Для товара можно определить скидку";
        }

        public void OnPostDiscont(string name, decimal? price, double discont)
        {
            Product = new Models.Product();
            var result = price * (decimal?)discont / 100;

            MessageRezult = $"Для товара {name} с ценой {price} и скидкой {discont} получится {result}";
            Product.Price = price;
            Product.Name = name;
        }

    }


}
