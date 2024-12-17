namespace ServiceOOP
{
    public class ServiceAuto
    {
        MoneyService moneyService = new MoneyService();
        Warehouse warehouse = new Warehouse();

        public void RepairCar(string needDetails)
        {
            foreach (KeyValuePair<string, int> detail in warehouse._details)
                if (needDetails == detail.Key)
                {
                    Console.WriteLine($"Цена за ремонт: {moneyService.ServiceRepair}руб.\n" +
                        $"Цена детали: {detail.Value}руб. Итог {moneyService.BalanceService = moneyService.ServiceRepair + detail.Value + moneyService.BalanceService}руб.");
                    warehouse._details.Remove(detail.Key);
                    Console.WriteLine("Ремонт выполнен успешно.");
                    break;
                }
                else
                {
                    Console.WriteLine("Такой детали нет. В ремонте отказано.");
                    Console.WriteLine($"Баланс: {moneyService.BalanceService = moneyService.BalanceService - moneyService.FineService}");
                    ClientFine();
                    break;
                }

        }

        public void ClientFine()
        {
            Console.WriteLine("В ремонте отказано.");
        }

        public void Exit()
        {
            Console.WriteLine("Выход из программы.");
        }
    }
}
