using Library_Management_System;
using System;
using System.Collections.Generic;


class Program
{
    // Main Method
    static void Main()
    {
        List<Book> books = new List<Book>();


        books.Add(new Book("War Of The Worlds", "H.G. Wells's iconic novel about a Martian invasion of Earth", "H.G. Wells", 12.99M, 75));
        books.Add(new Book("Dune", "A science fiction novel by Frank Herbert, about the young Paul Atreides, as he and his family accept control over the desert planet Arrakis", "Frank Herbert", 18.00M, 65));
        books.Add(new Book("Snow Crash", "A novel by Neal Stephenson that offers a futuristic vision of a world in the grip of a computer virus", "Neal Stephenson", 14.50M, 70));

        bool stopLoop = false;
        while (!stopLoop)
        {

            Console.WriteLine($"\n1. Display Books\n2. Add Book\n3. Remove Book\n4. Exit\n\nPlease Enter Your Choice: ");
            string input = Console.ReadLine();
            int choice;
            if (!int.TryParse(input, out choice))
            {
                Console.WriteLine("\nInvalid input. Please enter a number.");
                continue;
            }
            switch (choice)
            {
                case 1:
                    DisplayBooks();
                    break;
                case 2:
                    AddBook();
                    break;
                case 3:
                    RemoveBook();
                    break;
                case 4:
                    return;
                default:
                    Console.WriteLine("\nInvalid choice, please enter a number between 1 and 4.");
                    break;
            }

            // Methods
            // Method to display all books

            void DisplayBooks()
            {
                Console.WriteLine("\n=============================================\n");
                foreach (Book book in books)
                {
                    Console.WriteLine(books.IndexOf(book).ToString() + ". " + book + "\n"); // First print the Index of the book and then the book object (book.ToString())
                }
                Console.WriteLine("\n=============================================\n");
            }

            // Method to add a new book

            void AddBook()
            {
                Console.WriteLine("\nEnter the book name: ");
                string name = Console.ReadLine();
                Console.WriteLine("\nEnter the book description: ");
                string description = Console.ReadLine();
                Console.WriteLine("\nEnter the book author: ");
                string author = Console.ReadLine();
                Console.WriteLine("\nEnter the book price: ");
                decimal price = decimal.Parse(Console.ReadLine());
                Console.WriteLine("\nEnter the book's quantity on hand: ");
                int qtyOnHand = int.Parse(Console.ReadLine());

                books.Add(new Book(name, description, author, price, qtyOnHand));
            }

            void RemoveBook()
            {
                DisplayBooks();
                Console.WriteLine("\nEnter the index of the book you want to delete: ");
                int index = int.Parse(Console.ReadLine());
                books.RemoveAt(index); // Index starts from 0
            }
        }
    }
}