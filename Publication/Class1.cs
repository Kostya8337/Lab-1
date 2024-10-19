using System;

namespace Lab1
{
    public class Publication
    {
        private string title;
        private string type;
        private double price;
        private int pages;

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

        public void DisplayPublication()
        {
            Console.WriteLine($"Title: {title}, Type: {type}");
        }

        public void AnalyzePrice()
        {
            if (price > 10 && type.ToLower() == "newspaper")
            {
                Console.WriteLine($"This is an expensive newspaper: {price}");
            }
            else if (price < 10 && type.ToLower() == "magazine")
            {
                Console.WriteLine($"This is a cheap magazine: {price}");
            }
            else
            {
                Console.WriteLine($"This publication is a {type}. Its price is {price}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Publication publication = new Publication();
            publication.Title = "Tech Times";
            publication.Type = "Newspaper";
            publication.Price = 12;
            publication.Pages = 24;

            publication.DisplayPublication();
            publication.AnalyzePrice();
        }
    }
}
