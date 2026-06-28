namespace Task
{
    public class saving(string name,double balance,double interstRate):Account(name,balance)
    {
        public double InterstRate { get; set; } = interstRate;
        public override bool Deposit(double amount) => base.Deposit(amount + (amount * (InterstRate / 100)));
        
    }
}
