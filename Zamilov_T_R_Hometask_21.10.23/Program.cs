using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Упражнение 8.1 Тумаков");
        Account account1 = new Account("1234567890", 10000, AccountType.DEPOSIT);
        Account account2 = new Account("9876543210", 0, AccountType.CURRENT);

        account1.Transfer(account2, 5000);

        Console.WriteLine(account1);
        Console.WriteLine(account2);
        
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("Упражнение 8.2 Тумаков");
        string str = "Chuvak, alcohol is suck.";
        string reversedStr = ReverseString(str);

        Console.WriteLine(str);
        Console.WriteLine(reversedStr);
    }

    //Упражнение 8.2. Метод - Переворот букв.
    public static string ReverseString(string str)
    {
        char[] chars = str.ToCharArray();

        for (int i = 0, j = chars.Length - 1; i < j; i++, j--)
        {
            char temp = chars[i];
            chars[i] = chars[j];
            chars[j] = temp;
        }

        return new string(chars);
    }
}

class Account
{
    private string number;
    private double balance;
    private AccountType type;


    public Account(string number, double balance, AccountType type)
    {
        this.number = number;
        this.balance = balance;
        this.type = type;
    }


    public void SetNumber(string number)
    {
        this.number = number;
    }

    public string GetNumber()
    {
        return this.number;
    }

    public void SetBalance(double balance)
    {
        this.balance = balance;
    }

    public double GetBalance()
    {
        return this.balance;
    }

    public void SetType(AccountType type)
    {
        this.type = type;
    }

    public AccountType GetType()
    {
        return this.type;
    }


    public override string ToString()
    {
        return $"Номер счета: {this.number}\nБаланс: {this.balance}\nТип счета: {this.type}";
    }


    public void Transfer(Account toAccount, double amount)
    {
        if (this.balance >= amount)
        {
            this.balance -= amount;

            toAccount.balance += amount;
        }
    }
}

enum AccountType
{
    DEPOSIT,
    CURRENT
}

