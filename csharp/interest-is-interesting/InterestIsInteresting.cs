using System;

static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        if (balance < 0){
            return 3.213f;
        }else if (balance >= 0 & balance < 1000){
            return 0.5f;
        }else if (balance >= 1000 & balance < 5000){
            return 1.621f;
        }else{
            return 2.475f;
        }
    }

    public static decimal Interest(decimal balance)
    {
        return (decimal)SavingsAccount.InterestRate(balance)/100 * balance;
    }

    public static decimal AnnualBalanceUpdate(decimal balance)
    {
        return SavingsAccount.Interest(balance) + balance;
    }

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        int counter = 0;
        decimal desired = balance;
        do
        {
            desired = SavingsAccount.AnnualBalanceUpdate(desired);
            counter++;
        } while (targetBalance > desired);
        return counter;
    }
}
