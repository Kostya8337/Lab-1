using System;

class Publication
{
    // Поля класу
    private string title;
    private string type; // Газета чи журнал
    private double price;
    private int pages;

    // Властивості для доступу до полів
    public string Title
    {
        get { return title; }
        set { title = value; }
    }

    public string Type
    {
        get { return type; }
        set { type = value; }
    }

    public double Price
    {
        get { return price; }
        set { price = value; }
    }

    public int Pages
    {
        get { return pages; }
        set { pages = value; }
    }

    // Конструктор без параметрів
    public Publication()
    {
        // Ініціалізація через властивості
        this.Title = "Невідоме видання";
        this.Type = "газета";
        this.Price = 5.0;
        this.Pages = 30;
    }

    // Метод для виведення назви та типу видання
    public void PrintInfo()
    {
        Console.WriteLine($"Назва: {this.Title}, Тип: {this.Type}");
    }

    // Метод для аналізу ціни та типу
    public void AnalyzePrice()
    {
        if (this.Price > 10 && this.Type == "газета")
        {
            Console.WriteLine($"Це занадто дорога газета: {this.Price} грн.");
        }
        else if (this.Price < 10 && this.Type == "журнал")
        {
            Console.WriteLine($"Це дешевий журнал: {this.Price} грн.");
        }
        else
        {
            Console.WriteLine($"Це видання: {this.Type}. Його ціна: {this.Price} грн.");
        }
    }
}

class Program
{
    static void Main()
    {
        // Створення об'єкта друкарське видання
        Publication pub = new Publication();

        // Виведення інформації
        pub.PrintInfo();

        // Аналіз ціни
        pub.AnalyzePrice();

        // Зміна полів
        pub.Title = "Журнал Сучасність";
        pub.Type = "журнал";
        pub.Price = 9.0;
        pub.Pages = 50;

        // Повторний аналіз
        pub.AnalyzePrice();
    }
}
