namespace Task
{
    internal class Program
    {
        static void Main()
        {
            var accounts = new List<Account>();
            accounts.Add(new Account());
            accounts.Add(new Account("Larry"));
            accounts.Add(new Account("Moe", 2000));
            accounts.Add(new Account("Curly", 5000));

            AccountUtil.Display(accounts);
            AccountUtil.Deposit(accounts, 1000);
            AccountUtil.Withdraw(accounts, 2000);

            var savAccounts = new List<saving>();
            savAccounts.Add(new saving("Superman",0.0,3.5));
            savAccounts.Add(new saving("Batman", 2000,4.0));
            savAccounts.Add(new saving("Wonderwoman", 5000, 5.0));

            AccountUtil.Display(savAccounts);
            AccountUtil.Deposit(savAccounts, 1000);
            AccountUtil.Withdraw(savAccounts, 2000);

            var trustAccounts = new List<trust>();
            trustAccounts.Add(new trust("Superman2",2000,0.20));
            trustAccounts.Add(new trust("Batman2", 1000,0.10));
            trustAccounts.Add(new trust("Wonderwoman2", 5000, 5.0));

            AccountUtil.Display(trustAccounts);
            AccountUtil.Deposit(trustAccounts, 1000);
            AccountUtil.Deposit(trustAccounts, 6000);
            AccountUtil.Withdraw(trustAccounts, 2000);
            AccountUtil.Withdraw(trustAccounts, 3000);
            AccountUtil.Withdraw(trustAccounts, 500);
        }
    }
}
