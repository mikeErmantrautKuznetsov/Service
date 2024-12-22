namespace ServiceOOP
{
    public class AutoService
    {
        private readonly Warehouse _warehouse = new Warehouse();
        private readonly MoneyService _moneyService = new MoneyService();

        public void CarRepair(int needDetail)
        {
            if (_warehouse.TryGetDetail(needDetail, out DetailData product))
            {
                Console.WriteLine($"Цена за ремонт: {_moneyService.repairCost}руб.\n" +
                    $"Цена детали: {product.price}руб. Итог {_moneyService.balance = 
                    _moneyService.repairCost + product.price + _moneyService.balance}руб.");

                _warehouse.RemoveDetail(needDetail);
            }
            else
            {
                ServicePunishment();
            }

        }

        public void ServicePunishment()
        {
            Console.WriteLine("Такой детали нет. В ремонте отказано.");
            Console.WriteLine($"Баланс: {_moneyService.balance = _moneyService.balance - _moneyService.fineAmount}");
            Console.WriteLine("В ремонте отказано.");
        }
    }
}
