namespace ServiceOOP
{
    public class DetailData
    {
        public string name { get; set; }
        public int price { get; set; }

        public DetailData(string _name, int _price)
        {
            name = _name;
            price = _price;
        }
    }
}
