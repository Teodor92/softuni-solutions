namespace LibraryManagementSystem
{
    public class Library
    {
        private readonly List<Book> _books = new List<Book>();

        public void AddBook(Book book)
        {
            _books.Add(book);
        }

        public bool CheckOutBook(int bookId)
        {
            var book = _books.FirstOrDefault(b => b.Id == bookId && !b.IsCheckedOut);
            if (book == null)
            {
                return false;
            }

            book.IsCheckedOut = true;
            return true;
        }

        public bool ReturnBook(int bookId)
        {
            var book = _books.FirstOrDefault(b => b.Id == bookId && b.IsCheckedOut);
            if (book == null)
            {
                return false;
            }

            book.IsCheckedOut = false;
            return true;
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return _books;
        }
    }
}
