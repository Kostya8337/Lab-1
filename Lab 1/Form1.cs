using System;
using System.IO;

class Student
{
    // Приватні поля класу
    private string name;
    private int age;
    private int course;
    private double rating;

    // Конструктор з параметрами
    public Student(string name, int age, int course, double rating)
    {
        this.name = name;
        this.age = age;
        this.course = course;
        this.rating = rating;
    }

    // Властивості для доступу до полів
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public int Course
    {
        get { return course; }
        set { course = value; }
    }

    public double Rating
    {
        get { return rating; }
        set { rating = value; }
    }

    // Метод для редагування даних студента
    public void EditStudent(string newName, int newAge, double newRating)
    {
        this.Name = newName;
        this.Age = newAge;
        this.Rating = newRating;

        // Запис змінених даних в файл
        using (StreamWriter writer = new StreamWriter("student.txt"))
        {
            writer.WriteLine($"Name: {this.Name}");
            writer.WriteLine($"Age: {this.Age}");
            writer.WriteLine($"Course: {this.Course}");
            writer.WriteLine($"Rating: {this.Rating}");
        }
    }

    // Метод для виведення рейтингу студента
    public void StudentRating()
    {
        Console.WriteLine($"Рейтинг студента: {this.Rating}");
    }

    // Метод для визначення ролі за курсом
    public string GetRole()
    {
        if (this.Course >= 1 && this.Course <= 4)
            return "бакалавр";
        else if (this.Course >= 5 && this.Course <= 6)
            return "магістр";
        else
            return "невідомий рівень";
    }
}

class Program
{
    static void Main()
    {
        // Створення об'єкта студент
        Student student = new Student("Іван", 20, 3, 4.5);

        // Виклик методів
        student.StudentRating();
        Console.WriteLine(student.GetRole());

        // Редагування даних студента
        student.EditStudent("Петро", 21, 4.8);

        // Перевірка змін після редагування
        student.StudentRating();
        Console.WriteLine(student.GetRole());
    }
}
