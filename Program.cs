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
            AutoService serviceAuto = new AutoService();
            Warehouse warehouse = new Warehouse();
            MoneyService moneyService = new MoneyService();

            Console.WriteLine("Склад.");
            Console.WriteLine();
            Console.WriteLine(moneyService.balance);
            Console.WriteLine();
            warehouse.DisplayDetails();
            Console.WriteLine();

            bool _exitGame = false;

            while (_exitGame != true)
            {
                Console.WriteLine("Выберите команду: 1 - Ремонт машины. 2 - Выход из программы.");
                string agreeRepeat = Console.ReadLine();
                if (int.TryParse(agreeRepeat, out int resultChoice))

                    switch (resultChoice)
                    {
                        case (int)ComandConsole.CarRepair:
                            Console.WriteLine();
                            Console.WriteLine("Напишите индекс сломанной детали:");
                            int needDetail = Convert.ToInt32(Console.ReadLine());
                            serviceAuto.CarRepair(needDetail);
                            break;

                        case (int)ComandConsole.ExitProgram:
                            Console.Clear();
                            _exitGame = true;
                            break;

                        default:
                            Console.WriteLine("К сожалению у нас нет деталей для ремонта. " +
                                "\nБей отказ из-за нарушений правил эксплуатациию.");
                            break;
                    }

            }

        }
    }
}

enum ComandConsole
{
    CarRepair = 1,
    ExitProgram = 2
}