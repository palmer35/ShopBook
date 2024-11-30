namespace ShopBook;

class Program
{
    static void Main()
    {

        using (ApplicationContext context = new ApplicationContext())
        {
            context.Book.Add(new Book(1,"123", "34", "1234", 13, 89));
            context.SaveChanges();
        }



        // Завоз книг в магазин
        BookFinder book = new BookFinder();
        book.AddBook(new Book(1, "Анна Каренина", "Лев Толстой", "Роман", 1877, 864));
        book.AddBook(new Book(2, "Преступление и наказание", "Федор Достоевский", "Роман", 1866, 430));
        book.AddBook(new Book(3, "Евгений Онегин", "Александр Пушкин", "Поэма", 1833, 480));
        book.AddBook(new Book(4, "Вишневый сад", "Антон Чехов", "Пьеса", 1904, 120));
        book.AddBook(new Book(5, "Отцы и дети", "Иван Тургенев", "Роман", 1862, 350));
        book.AddBook(new Book(6, "Мастер и Маргарита", "Михаил Булгаков", "Роман", 1966, 384));
        book.AddBook(new Book(7, "На дне", "Максим Горький", "Пьеса", 1902, 200));
        book.AddBook(new Book(8, "Доктор Живаго", "Борис Пастернак", "Роман", 1957, 560));
        book.AddBook(new Book(9, "Лолита", "Владимир Набоков", "Роман", 1955, 336));
        book.AddBook(new Book(10, "Старуха", "Даниил Хармс", "Повесть", 1939, 70));

        book.SearchAuthor("Лев Толстой");
        book.SearchAuthor("Олег Меньшиков");
        book.SearchId(1);
        book.FindBooksAuthorGenre("лев толстой", "Роман");

        Console.WriteLine("\n\n=====================\n\n");
        BookStoreManager manager = new BookStoreManager();
        User user = new User(1, "Pavel", "pavlik33546@gmail.com", "8-902-646-62-25", 1000);
        user.PrintUser();
        manager.PurchaseBook(1, user, book);
    }
}