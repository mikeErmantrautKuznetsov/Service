namespace ServiceOOP
{
    //    У вас есть автосервис, в который приезжают люди, чтобы починить свои автомобили.
    //У вашего автосервиса есть баланс денег и склад деталей.
    //Когда приезжает автомобиль, у него сразу ясна его поломка, и эта поломка отображается у вас в консоли вместе с ценой за починку(цена за починку складывается из цены детали + цена за работу).
    //Поломка всегда чинится заменой детали, но количество деталей ограничено тем, что находится на вашем складе деталей.
    //Если у вас нет нужной детали на складе, то вы можете отказать клиенту, и в этом случае вам придется выплатить штраф.
    //За каждую удачную починку вы получаете выплату за ремонт, которая указана в чек-листе починки.
    //Класс Деталь не может содержать значение “количество”. Деталь всего одна, за количество отвечает тот, кто хранит детали.При необходимости можно создать дополнительный класс для конкретной детали и работе с количеством.

    public class Program
    {
        static void Main(string[] args)
        {
            ServiceAuto serviceAuto = new ServiceAuto();
            Warehouse warehouse = new Warehouse();
            MoneyService moneyService = new MoneyService();

            Console.WriteLine("Склад.");
            Console.WriteLine();
            warehouse.Check();
            Console.WriteLine();

            Console.WriteLine("Выберите команду: 1 - Ремонт машины. 2 отказ в ремонте.");
            string agreeRepeat = Console.ReadLine();
            if (int.TryParse(agreeRepeat, out int resultChoice))

                switch (resultChoice)
                {
                    case 1:
                        Console.WriteLine();
                        Console.WriteLine("Напишите сломанную деталь:");
                        warehouse.RenovateCar();
                        serviceAuto.RepairCar();
                        break;
                    case 2:
                        serviceAuto.ClientFine();
                        Console.WriteLine($"Баланс: {moneyService.BalanceService - moneyService.FineService}");
                        break;
                    default:
                        Console.WriteLine("К сожалению у нас нет деталей для ремонта. Бей отказ из-за нарушений правил эксплуатациию.");
                        break;
                }

        }
    }
}