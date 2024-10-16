using System;

class Publication
{
    // ���� �����
    private string title;
    private string type; // ������ �� ������
    private double price;
    private int pages;

    // ���������� ��� ������� �� ����
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

    // ����������� ��� ���������
    public Publication()
    {
        // ����������� ����� ����������
        this.Title = "������� �������";
        this.Type = "������";
        this.Price = 5.0;
        this.Pages = 30;
    }

    // ����� ��� ��������� ����� �� ���� �������
    public void PrintInfo()
    {
        Console.WriteLine($"�����: {this.Title}, ���: {this.Type}");
    }

    // ����� ��� ������ ���� �� ����
    public void AnalyzePrice()
    {
        if (this.Price > 10 && this.Type == "������")
        {
            Console.WriteLine($"�� ������� ������ ������: {this.Price} ���.");
        }
        else if (this.Price < 10 && this.Type == "������")
        {
            Console.WriteLine($"�� ������� ������: {this.Price} ���.");
        }
        else
        {
            Console.WriteLine($"�� �������: {this.Type}. ���� ����: {this.Price} ���.");
        }
    }
}

class Program
{
    static void Main()
    {
        // ��������� ��'���� ���������� �������
        Publication pub = new Publication();

        // ��������� ����������
        pub.PrintInfo();

        // ����� ����
        pub.AnalyzePrice();

        // ���� ����
        pub.Title = "������ ���������";
        pub.Type = "������";
        pub.Price = 9.0;
        pub.Pages = 50;

        // ��������� �����
        pub.AnalyzePrice();
    }
}
