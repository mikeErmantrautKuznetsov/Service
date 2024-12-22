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
                    $"Название: {detailsValues.Value.name}. \n" +
                    $"Цена: {detailsValues.Value.price}.");
            }
        }

        public bool TryGetDetail(int key, out DetailData detail)
        {
            return _details.TryGetValue(key, out detail);
        }

        public void RemoveDetail(int key)
        {
            _details.Remove(key);
        }
    }
}
