namespace Refactoring.MoveMethod
{
    public class Account
    {
        private readonly AccountType _type;

        public Account(AccountType type, int daysOverdrawn)
        {
            _type = type;
            DaysOverdrawn = daysOverdrawn;
        }

        public int DaysOverdrawn { get; }

        public double Bankcharge()
        {
            var result = 4.5;

            result += OverdraftCharge();

            return result;
        }

        private double OverdraftCharge()
        {
            if (_type.IsPremium)
            {
                double result = 10;
                if (DaysOverdrawn > 7)
                    result += (DaysOverdrawn - 7) * 1.0;
                return result;
            }
            return DaysOverdrawn * 1.75;
        }
        
    }
}