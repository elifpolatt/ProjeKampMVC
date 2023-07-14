using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public class CategoryRepositories : ICategoryDal
    {
        //ICategoryDaldan kalıtım aldık. Icategorydalın uzerıne gelip dataaccesslayer.abstract ile kullan dedık. Ve yıne altını cızdı. uzerıne gelip implement interface diyoruz ve burda yazan metotlar gelmıs oldu 

        //bunları da burada tanımladık. objectın turu dbset seklınde olacak. Category sınıfını tanımladık.
        Context c = new Context();
        DbSet<Category> _object; //değerleri tutuyor.


        //Not: Bu crud işlemleri için tek tek her tablo için bu sekılde yapılar olusturmak mantıklı degıldır. şimdilik bunu gormek ıcın yapıyoruz bu cok saglıksız ve kod tekrarına yol acan bır durumdur.

        //Silme işlemi
        public void Delete(Category p)
        {
            _object.Remove(p);
            c.SaveChanges();
        }

        //ekleme
        public void Insert(Category p)
        {
            _object.Add(p); //parametreden gelen degerlerı ekledik
            c.SaveChanges();
        }

        //Listeleme
        public List<Category> List()
        {
            //Listeleme işlemi için objectten gelen ifadeyi tolişst ile listele dedik.
         return _object.ToList();
        }

        //Güncelleme 
        public void Update(Category p)
        {
            c.SaveChanges();
        }

        public List<Category> List(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Category Get(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public decimal Sum(Expression<Func<Category, decimal>> selector)
        {
            throw new NotImplementedException();
        }
    }
}
