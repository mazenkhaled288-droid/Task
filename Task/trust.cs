namespace Task
{
    internal class trust(string name,double balance,double interstRate):saving(name, balance, interstRate)
    {
        public override bool Deposit(double amount)
        {
            if(amount>=5000.0)
            {
                amount += 50.0;
            }
            return base.Deposit(amount);
        }
        private int withdrawCount = 0;
        public override bool Withdraw(double amount)
        {
            if(withdrawCount>=3||amount>=(balance*0.20))
            {
                return false;
            }
            bool isSucces = base.Withdraw(amount);
                if(isSucces)
            {
                withdrawCount++;
            }
            return isSucces;
        }
    }
}
