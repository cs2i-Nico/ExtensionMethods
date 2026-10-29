namespace ExtensionMethods;
public static class ProductListExtensions
{
    public static int StockQuantity(this List<Product> list)
    {
         if (list.Count == 0)
        {
            return 0;
        }
        int totalQuantity = 0;
        foreach (var product in list)
        {
            totalQuantity += product.Quantity;
        }
        return totalQuantity;
    }

    public static double StockValue(this List<Product> list)
    {
         if (list.Count == 0)
        {
            return 0;
        }
        double totalStockValue = 0;
        foreach (var product in list)
        {
            totalStockValue += product.Price * product.Quantity;
        }
        return totalStockValue;
    }

    public static double AveragePrice(this List<Product> list)
    {
        if (list.Count == 0)
        {
            return 0;
        }

        double totalPrice = 0;
        foreach (var product in list)
        {
            totalPrice += product.Price;
        }
        return totalPrice / list.Count;
    }

    public static double MaxPrice(this List<Product> list)
    {
        if (list.Count == 0)
        {
            return 0;
        }

        double maxPrice = list[0].Price;
        foreach (var product in list)
        {
            if (product.Price > maxPrice)
            {
                maxPrice = product.Price;
            }
        }
        return maxPrice;
    }

    public static double MinPrice(this List<Product> list)
    {
        if (list.Count == 0)
        {
            return 0;
        }

        double minPrice = list[0].Price;
        foreach (var product in list)
        {
            if (product.Price < minPrice)
            {
                minPrice = product.Price;
            }
        }
        return minPrice;
    }
}