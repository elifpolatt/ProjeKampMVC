using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {

        ICategoryDal _categorydal; //kullanabilmek için ctor oluşturmlaıyız.

        //ctor
        public CategoryManager(ICategoryDal categorydal)
        {
            _categorydal = categorydal;
        }

        //kategori ekleme işlemi
        public void CategoryAddBL(Category category)
        {

            _categorydal.Insert(category);
        }

       

        //kategori silme işlemi
        public void CategoryRemoveBL(Category category)
        {
            _categorydal.Delete(category);
        }

        //kategori güncelleme işlemi
        public void CategoryUpdateBL(Category category)
        {
            _categorydal.Update(category);
        }

        public Category GetById(int id)
        {
            return _categorydal.Get(x => x.CategoryId == id);
            
        }

        //kategori listeleme
        public List<Category> GetList()
        {
            return _categorydal.List();
        }


    }
}
