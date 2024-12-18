namespace ServiceOOP
{
    public class ServiceAuto
    {
        MoneyService moneyService = new MoneyService();
        Warehouse warehouse = new Warehouse();

        public void RepairCar(string needDetails)
        {
            if (needDetails != null)
            {
                warehouse.RemoveDetail(needDetails);
                Console.WriteLine("Ремонт выполнен успешно.");
            }
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
