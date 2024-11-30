namespace ShopBook
{
    public class BookFinder
    {
        protected List<Book> Books = new List<Book>(); 

        public void AddBook(Book book)
        {
            Books.Add(book);
            Console.WriteLine($"Книга '{book.TitleBook}' добавлена в магазин.");
        }

        public void RemoveBook(int id)
        {
            var foundBook = Books.FirstOrDefault(b => b.IdBook == id);
            if (foundBook == null)
            {
                Console.WriteLine($"Книга с ID = '{id}' не найдена");
            }
            else
            {
                Books.Remove(foundBook);
                Console.WriteLine($"Книга с ID = {foundBook.IdBook} удалена ");
            }
        }

        public void SearchAuthor(string author)
        {
            var foundBooks = Books.Where(b => b.Author.Equals(author, StringComparison.OrdinalIgnoreCase)).ToList();
            if (foundBooks.Count == 0)
            {
                Console.WriteLine($"Книги по автору '{author}' не найдены.");
            }
            else
            {
                Console.WriteLine($"Книги по автору '{author}':");
                foreach (var book in foundBooks)
                {
                    Console.WriteLine($"ID: {book.IdBook}, Название: {book.TitleBook}, Автор: {book.Author}, Жанр: {book.GenreBook}, Год: {book.PublishedYear}, Цена: {book.Price}");
                }
            }
        }

        public void SearchGenre(string genre)
        {
            var foundBooks =  Books.Where(b => b.GenreBook.Equals(genre, StringComparison.OrdinalIgnoreCase)).ToList();
            if (foundBooks.Count == 0)
            {
                Console.WriteLine($"Книги по жанру '{genre}' не найдены ");
            }
            else
            {
                Console.WriteLine($"Книги по жанру '{genre}': ");
                foreach (var book in foundBooks)
                {
                    Console.WriteLine($"ID: {book.IdBook}, Название: {book.TitleBook}, Автор: {book.Author}, Жанр: {book.GenreBook}, Год: {book.PublishedYear}, Цена: {book.Price}");
                }
            }
        }

        public Book? SearchId(int id)
        {
            var foundBook = Books.FirstOrDefault(b => b.IdBook == id);

            if (foundBook == null)
            {
                Console.WriteLine($"Книга с ID = '{id}' не найдена");
                return null; 
            }
            else
            {
                Console.WriteLine($"Книга с ID = {foundBook.IdBook}, Название: {foundBook.TitleBook}, Автор: {foundBook.Author}, Жанр: {foundBook.GenreBook}, Год: {foundBook.PublishedYear}, Цена: {foundBook.Price}");
                return foundBook; 
            }
        }
        public void FindBooksAuthorGenre(string author, string genre)
        {
            var foundBooks = Books.Where(b =>
                b.Author.Equals(author, StringComparison.OrdinalIgnoreCase) &&
                b.GenreBook.Equals(genre, StringComparison.OrdinalIgnoreCase)
            ).ToList();

            if (foundBooks.Count == 0)
            {
                Console.WriteLine($"Книг автора '{author}' с жанром '{genre}' не найдено");
            }
            else
            {
                Console.WriteLine($"Книги автора '{author}' с жанром '{genre}': ");
                foreach (var book in foundBooks)
                {
                    Console.WriteLine(
                        $"ID: {book.IdBook}, Название: {book.TitleBook}, Автор: {book.Author}, Жанр: {book.GenreBook}, Год: {book.PublishedYear}, Цена: {book.Price}");
                }
            }
        }

        public void DisplayAllBooks()
        {
            if (Books.Count == 0)
            {
                Console.WriteLine("В магазине нет книг.");
                return;
            }

            foreach (var book in Books)
            {
                Console.WriteLine($"ID: {book.IdBook}, Название: {book.TitleBook}, Автор: {book.Author}, Жанр: {book.GenreBook}, Год: {book.PublishedYear}, Цена: {book.Price}");
            }
        }
    }
}
