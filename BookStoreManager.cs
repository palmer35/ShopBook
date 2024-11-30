namespace ShopBook
{
    public class BookStoreManager
    {
        public void PurchaseBook(int bookId, User user, BookFinder bookFinder)
        {

            var book = bookFinder.SearchId(bookId);
            if (book == null)
            {
                Console.WriteLine("Книга не найдена.");
                return;
            }

            var totalCost = book.Price;
            if (!user.DeductBalance(totalCost))
            {
                Console.WriteLine($"Покупателю '{user.Name}' не хватает денег. Нужно {totalCost}, а есть {user.Wallet}.");
                return;
            }

            bookFinder.RemoveBook(bookId);

            Console.WriteLine($"Покупатель '{user.Name}' купил книгу '{book.TitleBook}' за {totalCost}. Остаток денег: {user.Wallet}.");
        }
    }
}