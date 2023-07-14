using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    //Genericrepository bir tane deger alacak ve interfaceten de Irepositorydeki değerleri alacaksın. ve gonderecegım T degeri bir class olmalıdır
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        Context c = new Context();
        DbSet<T> _object;
        //object: T degerine karsılık gelen sınıflar
        //T degerine karsilik gelen sınıfı constructor ile bulacagız.


        //Ctor:
        public GenericRepository()
        {
            //object degerim dısardan gonderdıgım entity neyse o olacak
            _object = c.Set<T>();

        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public void Delete(T p)
        {
            var deletedEntity = c.Entry(p);
            deletedEntity.State = EntityState.Deleted;
            //_object.Remove(p);
            c.SaveChanges();
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            return _object.SingleOrDefault(filter);
            //bir dizide veya listede sadece bir tane deger geriye döndürmek icin kullanılan linq.
        }

        public void Insert(T p)
        {
            //entity ekle
            var addedEntity = c.Entry(p);
            addedEntity.State = EntityState.Added;
            //_object.Add(p);
            c.SaveChanges();
        }

        public List<T> List()
        {
            return _object.ToList();
        }

        //buradaki listin SingleOrDefault'tan farkı burada l ist metotunda komple bir listeyi dönderiyoruz. liste icinde ismi ali olan yazarlar dersek bu sekılde kullanılacak ama id= 5 olan yazar dersek         T Get(Expression<Func<T, bool>> filter); kullanılacak üstteki halıyle
        public List<T> List(Expression<Func<T, bool>> filter)
        {
            //filterdan gelen deger icin bana listeleme yapacaksın.
            return _object.Where(filter).ToList();
        }

        public decimal Sum(Expression<Func<T, decimal>> selector)
        {
            throw new NotImplementedException();
        }

        public void Update(T p)
        {
            var updatedEntity = c.Entry(p);
            updatedEntity.State = EntityState.Modified;
            c.SaveChanges();
        }
    }
}
