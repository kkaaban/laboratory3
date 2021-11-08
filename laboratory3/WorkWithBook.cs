using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratory3
{
    static class WorkWithBook
    {
        // 5 книг, с которыми мы будем работать и структуры данных
        static Book book1 = new Book()
        {
            SerialNumber = "ISBN 978-5-93673-265-2",
            Title = "Время жить и время умирать",
            YearOfPub = new DateTime(year: 2005, 1, 1),
            Price = 200,
            Quantity = 5000
        };
        static Book book2 = new Book("ISBN 978-5-93673-266-2", "Собачье сердце", new DateTime(year: 2020, 1, 1), 75, 1000);
        static Book book3 = new Book("ISBN 978-5-93673-267-2", Title: "Шагреневая кожа", new DateTime(year: 2018, 1, 1), 175, 150);
        static Book book4 = new Book(SerialNumber: "ISBN 978-5-93673-268-2", Title: "50 оттенков серого", YearOfPub: new DateTime(year: 2015, 1, 1), Price: 400, Quantity: 5);
        static Book book5 = new Book();
        static Book[] booksArray = new Book[] { book1, book2, book3, book4, book5 };


        public static string GetInformation()
        {
            string info = "";
            for (int i = 0; i < booksArray.Length; i++)
            {
                info += booksArray[i].GetInformation() + "\n\n";
            }
            return info;
        }
        public static string GetInformationOfIndex(int index) => booksArray[index].GetInformation();
        public static decimal GetPriceAllBook(int index) => booksArray[index].PriceAllBooks;
        public static void ChanchePrice(int index, int percent) => booksArray[index].PriceChangePercent(percent);
        public static Book[] GetArrayBook() => booksArray;
        public static void AssignValue(Book[] array) => booksArray = array;
        public static void CreateBookArray(string SerialNumber = "", string Title = "", DateTime YearOfPub = default, decimal Price = 0, uint Quantity = 0)
        {
            Array.Resize(ref booksArray, booksArray.Length + 1);
            booksArray[booksArray.Length - 1] = new Book(SerialNumber, Title, YearOfPub, Price, Quantity);
        }

    }
}
