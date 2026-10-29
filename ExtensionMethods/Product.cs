namespace ExtensionMethods;
public class Product : IComparable
{
    public string Id { get; set; }
    public string Name { get; set; }

    public Double Price { get; set; }

    public int Quantity { get; set; }

    public Product(string id, string name, Double price, int quantity)
    {
        this.Id = id;
        this.Name = name;
        this.Price = price;
        this.Quantity = quantity;
    }

    public int CompareTo(object? obj)
    {
        // comparer le stock des produits et en fonction du resultat renvoyer -1, 0 ou 1
        if (obj == null) return 1;

        Product? p = obj as Product;
        if (p != null)
        {
            if (this.Quantity < p.Quantity)
            {
                return -1;
            }
            else if (this.Quantity > p.Quantity)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        else
        {
            throw new InvalidCastException("Object is not a Product");
        }
    }
}