namespace ServiceOOP
{
    //    У вас есть автосервис, в который приезжают люди, чтобы починить свои автомобили.
    //У вашего автосервиса есть баланс денег и склад деталей.
    //Когда приезжает автомобиль, у него сразу ясна его поломка, и эта поломка отображается у вас в консоли вместе с ценой за починку(цена за починку складывается из цены детали + цена за работу).
    //Поломка всегда чинится заменой детали, но количество деталей ограничено тем, что находится на вашем складе деталей.
    //Если у вас нет нужной детали на складе, то вы можете отказать клиенту, и в этом случае вам придется выплатить штраф.
    //За каждую удачную починку вы получаете выплату за ремонт, которая указана в чек-листе починки.
    //Класс Деталь не может содержать значение “количество”. Деталь всего одна, за количество отвечает тот, кто хранит детали.При необходимости можно создать дополнительный класс для конкретной детали и работе с количеством.

    public class MoneyService
    {
        private int _balanceService = 100000;
        private int _sactionService = 1000;
        private int _repeatService = 2000;

        public int BalanceService { get { return _balanceService; } set { _balanceService = value; } }
        public int SactionService { get { return _sactionService; } set { _sactionService = value; } }
        public int RepeatService { get { return _repeatService; } set { _repeatService = value; } }

    }

    public class Warehouse
    {
        MoneyService moneyService = new MoneyService();
        ServiceAuto serviceAuto1 = new ServiceAuto();

        Dictionary<string, int> details = new Dictionary<string, int>()
        {
            {"двигатель", 5000},
            {"тормаза", 1000},
            {"генератор", 2000},
            {"аккамулятор", 500},
            {"бензобак", 1500}
        };

        public void Cheack()
        {
            foreach (KeyValuePair<string, int> detailsValues in details)
            {
                Console.WriteLine(detailsValues);
            }
        }

        public void RenovatCar()
        {
            string needDetails = Console.ReadLine();
            Console.WriteLine();
            foreach (KeyValuePair<string, int> detail in details)
                if (needDetails == detail.Key)
                {
                    Console.WriteLine($"Цена за ремонт: {moneyService.RepeatService}руб.\n" +
                        $"Цена детали: {detail.Value}руб. Итог {moneyService.RepeatService + detail.Value + moneyService.BalanceService}руб.");
                    details.Remove(detail.Key);
                    break;
                }
                else if (needDetails != detail.Key)
                {
                    serviceAuto1.SactionClient();
                    Console.WriteLine($"Баланс: {moneyService.BalanceService - moneyService.SactionService}");
                    break;
                }
        }
    }


    public class ServiceAuto
    {
        public void RepairCar()
        {
            Console.WriteLine("Ремонт выполнен успешно.");
        }

        public void SactionClient()
        {
            Console.WriteLine("В ремонте отказано.");
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            ServiceAuto serviceAuto = new ServiceAuto();
            Warehouse warehouse = new Warehouse();
            MoneyService moneyService = new MoneyService();

            Console.WriteLine("Склад.");
            Console.WriteLine();
            warehouse.Cheack();
            Console.WriteLine();

            Console.WriteLine("Выберите команду: 1 - Ремонт машины. 2 отказ в ремонте.");
            string agreeRepeat = Console.ReadLine();
            if (int.TryParse(agreeRepeat, out int resultChoice))

                switch (resultChoice)
                {
                    case 1:
                        Console.WriteLine();
                        Console.WriteLine("Напишите сломанную деталь:");
                        warehouse.RenovatCar();
                        serviceAuto.RepairCar();
                        break;
                    case 2:
                        serviceAuto.SactionClient();
                        Console.WriteLine($"Баланс: {moneyService.BalanceService - moneyService.SactionService}");
                        break;
                    default:
                        Console.WriteLine("К сожалению у нас нет деталей для ремонта. Бей отказ из-за нарушений правил эксплуатациию.");
                        break;
                }

        }
    }
}