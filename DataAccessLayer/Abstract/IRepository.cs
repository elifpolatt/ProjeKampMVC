using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<T>
    {
        //dısarıdan gelen entity'yi yanı tabloyu burada vermek ıcın T'ı kullandık. tür değeri.
        //CRUD
        List<T> List();
        void Insert(T p);
        T Get(Expression<Func<T, bool>> filter);
        void Delete(T p);
        void Update(T p);
        //şartlı listeleme için kullanılıyor. Bu bir syntaxtır. arama için
        List<T> List(Expression<Func<T, bool>> filter);

        //sayma toplam sayısı için
        int Count();
        decimal Sum(Expression<Func<T, decimal>> selector);

    }
}
