using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMS_model;
using System.Data.Entity;
namespace LMS_Core.Business
{
   
   public  class BookBL
    {
        private LibarayDBContext db = new LibarayDBContext();

        public Book book = new Book();
        
        public List<Book> GetAllbook()
        {
            var listOfBooks = db.Books.ToList();
            return listOfBooks;
        }
        public List<Book> Search(string title)
        {
            var listOfBooks = db.Books.Where(s=>s.title.Contains(title.Trim())).ToList();
            return listOfBooks;
        }

       public bool CheckIdIsNull(int? id)
        {
            if (id == null)
                return false;
            else
                return true;
        }
       public Book GetDetails(int? id)
        {
            bool check = CheckIdIsNull(id);
            var BookDetails = db.Books.Find(id);
           if(check)
           {
               return BookDetails;
           }
           else
               return HttpNotFound(); 
        }

       private Book HttpNotFound()
       {
           throw new NotImplementedException();
       }
             
       public void CreateBook(Book book)
       {
           db.Books.Add(book);
           db.SaveChanges();
       }

       public Book CheckFind(int?id)
       {
           var book = db.Books.Find(id);
           return book;
       }
       public void EditBookData(Book book)
       {
           
           
               db.Entry(book).State = EntityState.Modified;
               db.SaveChanges();   
       }
       public void Delete(int ?id)
       {
           Book book = db.Books.Find(id);
           db.Books.Remove(book);
           db.SaveChanges();
       }
    }
}
