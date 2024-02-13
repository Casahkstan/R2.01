namespace exo1
{
    /// <summary>
    /// A simple product
    /// </summary>
    public class Product
    {
        private static float vAT;
        private string code;
        private string name;
        private float priceIT;

        /// <summary>
        /// Init the product
        /// </summary>
        /// <param name="code">the unique code of the product</param>
        /// <param name="name">the name of the product</param>
        /// <param name="price">The price (include tax) of the product</param>
        public Product(string code, string name, float price)
        {
            this.code = code;
            this.name = name;
            this.priceIT = price;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public float PriceET
        {
            get => priceIT / (1 + VAT);
            set => priceIT = value * (1 + VAT);
        }

        public float PriceIT
        {
            get => priceIT;
            set => priceIT = value;
        }

        public static float VAT
        {
            get => vAT;
            set => vAT = value;
        }
    }
}