namespace ServiceOOP
{
    public class MoneyService
    {
        private int _balanceService = 100000;
        private int _fineService = 1000;
        private int _serviceRepair = 2000;

        public int BalanceService { get { return _balanceService; } set { _balanceService = value; } }
        public int FineService { get { return _fineService; } set { _fineService = value; } }
        public int ServiceRepair { get { return _serviceRepair; } set { _serviceRepair = value; } }
    }
}
