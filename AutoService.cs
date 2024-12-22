namespace ServiceOOP
{
    public class ServiceAuto
    {
        MoneyService moneyService = new MoneyService();

        public void RepairCar(int needDetails)
        {
            Console.WriteLine($"Цена за ремонт: {moneyService.serviceRepair}руб.\n" +
                $"Цена детали: {needDetails}руб. Итог {moneyService.balanceService = moneyService.serviceRepair + needDetails + moneyService.balanceService}руб.");
        }

        public void ClientFine()
        {
            Console.WriteLine("Такой детали нет. В ремонте отказано.");
            Console.WriteLine($"Баланс: {moneyService.balanceService = moneyService.balanceService - moneyService.fineService}");
            Console.WriteLine("В ремонте отказано.");
        }

        public void Exit()
        {
            Console.WriteLine("Выход из программы.");
        }
    }
}
