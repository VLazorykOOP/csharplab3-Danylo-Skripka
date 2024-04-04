using System;

class Money
{
    // Поля
    protected int nominal;
    protected int num;

    // Конструктор
    public Money(int nominal, int num)
    {
        this.nominal = nominal;
        this.num = num;
    }

    // Методи
    public void PrintMoney()
    {
        Console.WriteLine($"Номінал: {nominal}, Кількість купюр: {num}");
    }

    public bool CanBuy(double cost)
    {
        return cost <= TotalAmount();
    }

    public int CountItems(double cost)
    {
        return (int)(TotalAmount() / cost);
    }

    // Властивості
    public int Nominal
    {
        get { return nominal; }
        set { nominal = value; }
    }

    public int Num
    {
        get { return num; }
        set { num = value; }
    }

    public double TotalAmount()
    {
        return nominal * num;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Приклад використання класу Money
        Money wallet = new Money(100, 5); // Гаманець з 5 купюрами по 100 гривень кожна
        wallet.PrintMoney(); // Виводимо інформацію про гаманець

        double itemCost = 250; // Ціна товару
        int itemCount = wallet.CountItems(itemCost); // Визначаємо кількість товару, яку можна купити
        bool canBuy = wallet.CanBuy(itemCost); // Перевіряємо, чи можна купити товар

        if (canBuy)
        {
            Console.WriteLine($"Можна купити {itemCount} товару(-ів) за {itemCost} грн.");
        }
        else
        {
            Console.WriteLine("Недостатньо коштів для покупки товару.");
        }
    }
}
