namespace ServiceOOP
{
    public class Warehouse
    {
        MoneyService moneyService = new MoneyService();

        Dictionary<string, int> _details = new Dictionary<string, int>()
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

        public void RemoveDetail(string needDetails)
        {
            foreach (KeyValuePair<string, int> detail in _details)
                if (needDetails == detail.Key)
                {
                    Console.WriteLine($"Цена за ремонт: {moneyService.ServiceRepair}руб.\n" +
                        $"Цена детали: {detail.Value}руб. Итог {moneyService.BalanceService = moneyService.ServiceRepair + detail.Value + moneyService.BalanceService}руб.");
                    _details.Remove(detail.Key);
                    break;
                }
        }
    }
}
