namespace ServiceOOP
{
    public class Warehouse
    {

        Dictionary<int, DetailData> _details = new Dictionary<int, DetailData>()
        {
            {1, new DetailData("двигатель", 5000)},
            {2, new DetailData("тормаз", 1000)},
            {3, new DetailData("генератор", 2000)},
            {4, new DetailData("аккамулятор", 500)},
            {5, new DetailData("бензобак", 1500)}
        };

        public void DisplayDetails()
        {
            foreach (KeyValuePair<int, DetailData> detailsValues in _details)
            {
                Console.WriteLine($"Индекс: {detailsValues.Key}. \n" +
                    $"Название: {detailsValues.Value.NameDetail}. \n" +
                    $"Цена: {detailsValues.Value.PriceDetail}.");
            }
        }

        public bool TryGetDetail(int key, out DetailData detail)
        {
            detail = null;

            if (_details.ContainsKey(key))
            {
                detail = _details[key];
                return true;
            }
            return false;
        }

        public void RemoveDetail(int key)
        {
            _details.Remove(key);
        }
    }
}
