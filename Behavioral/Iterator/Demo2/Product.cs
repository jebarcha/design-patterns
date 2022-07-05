namespace DesignPatterns.Behavioral.Iterator.Demo2
{
    public class Product
    {
        private int _id;
        private string _name;

        public Product(int id, string name)
        {
            _id = id;
            _name = name;
        }

        public override string ToString()
        {
            return "Product{" +
                "id=" + _id +
                ", name='" + _name + '\'' +
                '}';
        }
    }
}
