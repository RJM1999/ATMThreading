using System;

class Account
{
    //the attributes for the account
    private int balance;
    private int pin;
    private int accountNum;

    // a constructor that takes initial values for each of the attributes (balance, pin, accountNumber)
    public Account(int balance, int pin, int accountNum)
    {
        this.balance = balance;
        this.pin = pin;
        this.accountNum = accountNum;
    }
    public Boolean decrementBalance(int amount)
    {
        if (this.balance >= amount)
        {
            balance -= amount;
            return true;
        }
        else
        {
            return true;
        }
    }
    //getter and setter functions for balance
    public int getBalance()
    {
        return balance;
    }
    public void setBalance(int newBalance)
    {
        this.balance = newBalance;
    }

    public int getAccountNum()
    {
        return this.accountNum;
    }

    public int getPin()
    {
        return this.pin;
    }

}
