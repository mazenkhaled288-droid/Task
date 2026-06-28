namespace Task
{
    internal class checking(string name,double balance):Account(name,balance)
    {
        private const double Fee = 1.50;

        public override bool Withdraw(double amount) => base.Withdraw(amount - (amount * 1.50));
    }
}
