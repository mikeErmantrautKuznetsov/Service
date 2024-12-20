namespace ServiceOOP
{
    public class DetailData
    {
        private string _nameDetail;
        private int _priceDetail;

        public DetailData(string _nameDetail, int _priceDetail)
        {
            NameDetail = _nameDetail;
            PriceDetail = _priceDetail;
        }

        public string NameDetail { get { return _nameDetail; } set { _nameDetail = value; } }
        public int PriceDetail { get { return _priceDetail; } set { _priceDetail = value; } }
    }
}
