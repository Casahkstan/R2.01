namespace R2._01.TD.TD_4;

public class Exo_1
{
    public class Category
    {
        private List<Product> _products;

        public List<Product> Products => _products;

        public Category(string name)
        {
            Name = name;
            _products = new List<Product>();
        }

        public string Name { get; set; }
    }

    public class Product
    {
        private Category _category;
        private string _name;

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public Product(Category category, string name)
        {
            _category = category;
            Name = name;
        }
    }

    public class Catalog
    {
        private List<Product> _products;

        public Catalog()
        {
            _products = new List<Product>();
        }

        public void AddProduct(Product p)
        {
            _products.Insert(_products.Count, p);
        }

        public void RemoveProduct(Product p)
        {
            _products.Remove(p);
        }

        public int GetSize()
        {
            return _products.Count;
        }

        public Product? FindProductByName(String name)
        {
            return _products.Find((product) => product.Name == name);
        }
    }
}