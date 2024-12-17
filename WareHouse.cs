
namespace ServiceOOP
{
    public class Warehouse
    {
        public Dictionary<string, int> _details = new Dictionary<string, int>()
        {
            {"двигатель", 5000},
            {"тормаз", 1000},
            {"генератор", 2000},
            {"аккамулятор", 500},
            {"бензобак", 1500}
        };

        public void DisplayDetails()
        {
            foreach (KeyValuePair<string, int> detailsValues in _details)
            {
                Console.WriteLine(detailsValues);
            }
        }
    }
}
