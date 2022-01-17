using BookReviewAPI.Data.Models;
using BookReviewAPI.Data.ViewModels;

namespace BookReviewAPI.Data.Services
{
    public class BookServices
    {
        private AppDbContex _context;
        public BookServices(AppDbContex context)
        {
         _context = context;
        }


        public void AddBook(BookVM book)
        {
            var _book = new Book()
            {
                BookTittle = book.BookTittle,
                Description = book.Description,
                Rate = book.Rate

            };
            _context.Books.Add(_book); 
            _context.SaveChanges();
        }
    }
}
