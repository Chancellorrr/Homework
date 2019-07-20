namespace Homework
{
    public class Transaction
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public decimal Amount { get; private set; }
        public BankAccount SourceAccount { get; private set; }

    }
}