namespace ShopBook
{
    public class Book
    {
        public int IdBook { get; set; } //id - книги
        public string TitleBook { get; set; } //название книги
        public string Author { get; set; } //Автор книги
        public int PublishedYear { get; set; } //год выпуска
        public string GenreBook { get; set; } //жанр книги
        public decimal Price { get; set; } //цена книги

        public Book()
        {
        }

        public Book(int id, string title, string author, string genre, int year, decimal price)
        {
            IdBook = id;
            TitleBook = title;
            Author = author;
            GenreBook = genre;
            PublishedYear = year;
            Price = price;
        }

        public void Puk()
        {
            Console.WriteLine("puk");
        }
    }
}
