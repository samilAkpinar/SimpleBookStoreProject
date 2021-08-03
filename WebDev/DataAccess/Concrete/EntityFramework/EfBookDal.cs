using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;


namespace DataAccess.Concrete.EntityFramework
{
    //Entity framework third party olduğu için ayrı bir klasörde aldık.
   //Kitaba özel listekeme getirme silme işlemleri hazırlamış olduk.
    public class EfBookDal: EfEntityRepositoryBase<Book,BookStoreContext> ,IBookDal
    {

    }
}
