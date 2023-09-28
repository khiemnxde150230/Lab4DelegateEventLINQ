using Question3_PerformLINQQueries;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        var brands = new List<Brand>()
        {
            new Brand{ID = 1, Name = "Công ty AAA"},
            new Brand{ID = 2, Name = "Công ty BBB"},
            new Brand{ID = 4, Name = "Công ty CCC"},
        };
        var products = new List<Product>()
        {
            new Product (1, "Bàn trà", 400, new string[] {"Xám", "Xanh"}, 2),
            new Product (2, "Tranh treo", 400, new string[] {"Vàng", "Xanh"}, 1),
            new Product (3, "Đèn trùm", 500, new string[] {"Trắng"}, 3),
            new Product (4, "Bàn học", 200, new string[] {"Trắng", "Xanh"}, 1),
            new Product (5, "Túi da", 300, new string[] {"Đỏ", "Đen", "Vàng"}, 2),
            new Product (6, "Giường ngủ", 500, new string[] {"Trắng"}, 2),
            new Product (7, "Tủ áo", 600, new string[] {"Trắng"}, 3),
        };
        // a. Filter out products with a price of 400.
        var filteredByPrice = products.Where(p => p.Price != 400).ToList();

        // b. Filter out products that contain the color yellow.
        var filteredByColor = products.Where(p => !p.Colors.Contains("Vàng")).ToList();

        // c. Display the list of products in descending order of price.
        var sortedByPriceDescending = products.OrderByDescending(p => p.Price).ToList();

        Console.WriteLine("Products filtered by price of 400):");
        DisplayProducts(filteredByPrice);

        Console.WriteLine("\nProducts filtered by color of yellow:");
        DisplayProducts(filteredByColor);

        Console.WriteLine("\nProducts sorted in descending order of price:");
        DisplayProducts(sortedByPriceDescending);
    }

    static void DisplayProducts(List<Product> productList)
    {
        foreach (var product in productList)
        {
            Console.WriteLine(product);
        }
    }
}