using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BookManager : IBookService
    {
        //DataAccess katmanına erişmek için abstract interface'i kullanılır.
        private IBookDal _bookDal;

        //DataAccess katmanındaki metotları kullanmak için constructorda tanımlama yapıyoruz. Bu da dependency injection tasarım desenidir.
        public BookManager(IBookDal bookDal)
        {
            _bookDal = bookDal;
        }

        public void Add(Book book)
        {
            //iş kodlarını yazarız.
            //Kitap eklerken kurallar var ise (proje gereyi) onlar buraya yazılır.
            //örnek Kullanım
            if(_bookDal.Get(b => b.Name == book.Name && b.AuthorId == book.AuthorId) == null)
            {
                _bookDal.Add(book);
            }
            else
            {
                throw new Exception("Bu kitap adı zaten mevcut");
            }

        }

        public void Delete(Book book)
        {
            //öncesinde kurallar var ise yapılır sonra silme işlemine gönderilebilir.
            _bookDal.Delete(book);
        }

        public List<Book> GetAll()
        {
            return _bookDal.GetList().ToList();
        }

        public List<Book> GetByAuthorId(int id)
        {
            return _bookDal.GetList(b => b.Id == id).ToList();
        }

        public Book GetById(int id)
        {
            return _bookDal.Get(b => b.Id == id);
        }

        public void Update(Book book)
        {
            _bookDal.Update(book);
        }
    }
}
