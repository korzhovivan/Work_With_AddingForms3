namespace WindowsFormsApp
{
    public class Item
    {


        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }

        public Item() { }

        public Item(string Name, int Price, string Description)
        {
            this.Name = Name;
            this.Price = Price;
            this.Description = Description;
        }
    }
}