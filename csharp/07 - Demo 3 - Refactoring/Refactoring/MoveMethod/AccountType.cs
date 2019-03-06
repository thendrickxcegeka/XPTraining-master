namespace Refactoring.MoveMethod
{
    public class AccountType
    {
        public AccountType(bool premium)
        {
            IsPremium = premium;
        }
        public bool IsPremium { get; }

    }
}