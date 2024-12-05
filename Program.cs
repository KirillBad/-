public class Account
{
    private int id;
    private double balance;

    public Account(int id, double initialBalance)
    {
        this.id = id;
        this.balance = initialBalance;
    }

    public int GetId() => id;

    public virtual bool Pay(double amount)
    {
        if (amount <= balance)
        {
            balance -= amount;
            return true;
        }
        return false;
    }

    public bool Transfer(Account to, double amount)
    {
        if (Pay(amount))
        {
            to.balance += amount;
            return true;
        }
        return false;
    }

    public double GetBalance() => balance;
}

public class CreditCard
{
    private int id;
    private double balance;
    private double limit;
    private bool isBlocked;

    public CreditCard(int id, double initialBalance, double limit)
    {
        this.id = id;
        this.balance = initialBalance;
        this.limit = limit;
        this.isBlocked = false;
    }

    public int GetId() => id;
    
    public double GetOverdraft() => limit - balance;
    
    public bool IsBlocked() => isBlocked;
    
    public void Block() => isBlocked = true;

    public double GetBalance() => balance;
    
    public double GetLimit() => limit;
}

public class Order
{
    private int id;
    private double amount;

    public Order(int id, double amount)
    {
        this.id = id;
        this.amount = amount;
    }

    public int GetId() => id;
    
    public double GetAmount() => amount;
}

public class Client
{
    private string name;
    private List<Account> accounts;
    private List<CreditCard> creditCards;

    public Client(string name)
    {
        this.name = name;
        accounts = new List<Account>();
        creditCards = new List<CreditCard>();
    }

    public void AddAccount(Account account)
    {
        accounts.Add(account);
    }

    public void AddCreditCard(CreditCard creditCard)
    {
        creditCards.Add(creditCard);
    }

    public bool PayOrder(Account account, Order order)
    {
        return account.Pay(order.GetAmount());
    }

    public bool TransferFunds(Account from, Account to, double amount)
    {
        return from.Transfer(to, amount);
    }

    public void BlockCreditCard(CreditCard creditCard)
    {
        creditCard.Block();
    }

    public void CloseAccount(Account account)
    {
        accounts.Remove(account);
    }
}

public class Administrator
{
    private string name;

    public Administrator(string name)
    {
        this.name = name;
    }

    public void BlockCreditCardIfOverLimit(CreditCard creditCard)
    {
        if (creditCard.GetBalance() > creditCard.GetLimit())
        {
            creditCard.Block();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Client client = new Client("Иван Иванов");

        Account account1 = new Account(1, 1000);
        Account account2 = new Account(2, 500);
        CreditCard creditCard = new CreditCard(1, 0, 1000);

        client.AddAccount(account1);
        client.AddAccount(account2);
        client.AddCreditCard(creditCard);

        Order order = new Order(1, 300);

        Console.WriteLine($"Баланс до оплаты: {account1.GetBalance()}");
        if (client.PayOrder(account1, order))
        {
            Console.WriteLine("Заказ успешно оплачен");
        }
        Console.WriteLine($"Баланс после оплаты: {account1.GetBalance()}");

        Console.WriteLine($"\nБаланс счета 1 до перевода: {account1.GetBalance()}");
        Console.WriteLine($"Баланс счета 2 до перевода: {account2.GetBalance()}");
        if (client.TransferFunds(account1, account2, 200))
        {
            Console.WriteLine("Перевод успешно выполнен");
        }
        Console.WriteLine($"Баланс счета 1 после перевода: {account1.GetBalance()}");
        Console.WriteLine($"Баланс счета 2 после перевода: {account2.GetBalance()}");

        Administrator admin = new Administrator("Админ");

        admin.BlockCreditCardIfOverLimit(creditCard);
        Console.WriteLine($"\nКарта заблокирована: {creditCard.IsBlocked()}");
    }
}
