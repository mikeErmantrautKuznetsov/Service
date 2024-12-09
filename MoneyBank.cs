using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceOOP
{
    public class MoneyService
    {
        private int _balanceService;
        private int _fineService;
        private int _serviceRepair;

        public int BalanceService { get; private set; } = 100000;
        public int FineService { get; private set; } = 1000;
        public int ServiceRepair { get; private set; } = 2000;

    }
}
