using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceOOP
{
    public class Warehouse
    {
        MoneyService moneyService = new MoneyService();

        Dictionary<string, int> details = new Dictionary<string, int>()
        {
            {"двигатель", 5000},
            {"тормаз", 1000},
            {"генератор", 2000},
            {"аккамулятор", 500},
            {"бензобак", 1500}
        };

        public void Check()
        {
            foreach (KeyValuePair<string, int> detailsValues in details)
            {
                Console.WriteLine(detailsValues);
            }
        }

        public void RenovateCar()
        {
            string needDetails = Console.ReadLine();
            Console.WriteLine();
            foreach (KeyValuePair<string, int> detail in details)
                if (needDetails == detail.Key)
                {
                    Console.WriteLine($"Цена за ремонт: {moneyService.ServiceRepair}руб.\n" +
                        $"Цена детали: {detail.Value}руб. Итог {moneyService.ServiceRepair + detail.Value + moneyService.BalanceService}руб.");
                    details.Remove(detail.Key);
                    break;
                }
        }
    }
}
