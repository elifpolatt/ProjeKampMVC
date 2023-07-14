using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class WriterManager : IWriterService
    {
        IWriterDal _writerDal; //kullanabilmek iicin ctor olusturdum.

        public WriterManager(IWriterDal writerDal)
        {
            _writerDal = writerDal;
                
        }
        public Writer GetByIDBL(int id)
        {
            return _writerDal.Get(x=>x.WriterId == id);
        }

        //yaza listeleme
        public List<Writer> Getlist()
        {
            return _writerDal.List();
        }

        //yazar ekleme
        public void WriterAddBL(Writer writer)
        {
            _writerDal.Insert(writer);
        }

        //yazar silme
        public void WriterRemoveBL(Writer writer)
        {
            _writerDal.Delete(writer);
        }

        public void WriterUpdateBL(Writer writer)
        {
            _writerDal.Update(writer);
        }
    }
}
