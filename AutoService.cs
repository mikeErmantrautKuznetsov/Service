namespace ServiceOOP
{
    public class ServiceAuto
    {
        MoneyService moneyService = new MoneyService();

        public void RepairCar(int needDetails)
        {
            Console.WriteLine($"Цена за ремонт: {moneyService.ServiceRepair}руб.\n" +
                $"Цена детали: {needDetails}руб. Итог {moneyService.BalanceService = moneyService.ServiceRepair + needDetails + moneyService.BalanceService}руб.");
        }

        public void ClientFine()
        {
            Console.WriteLine("Такой детали нет. В ремонте отказано.");
            Console.WriteLine($"Баланс: {moneyService.BalanceService = moneyService.BalanceService - moneyService.FineService}");
            Console.WriteLine("В ремонте отказано.");
        }

        public void Exit()
        {
            Console.WriteLine("Выход из программы.");
        }
    }
}
