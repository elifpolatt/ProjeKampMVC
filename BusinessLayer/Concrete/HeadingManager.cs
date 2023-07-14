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
    public class HeadingManager : IHeadingService
    {
        IHeadingDal _headingDal; //ctor olusturuyorum

        public HeadingManager(IHeadingDal headingDal)
        {
            _headingDal = headingDal;
        }
        public Heading GetByID(int id)
        {
            return _headingDal.Get(x=>x.HeadingId == id);
        }

        public List<Heading> Getlist()
        {
            return _headingDal.List();
        }

        public void HeadingAddBL(Heading heading)
        {
            _headingDal.Insert(heading);
        }

        public void HeadingRemoveBL(Heading heading)
        {
            _headingDal.Delete(heading);
        }

        public void HeadingUpdateBL(Heading heading)
        {
            _headingDal.Update(heading);
        }
    }
}
