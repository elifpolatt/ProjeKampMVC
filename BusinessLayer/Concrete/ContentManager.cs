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
    public class ContentManager : IContentService
    {
        IContentDal _contentDal;

        public ContentManager()
        {
        }

        //ctor
        public ContentManager(IContentDal contentDal)
        {
            _contentDal = contentDal;
        }

        public void ContentAddBL(Content content)
        {
            throw new NotImplementedException();
        }

        public void ContentRemoveBL(Content content)
        {
            throw new NotImplementedException();
        }

        public void ContentUpdateBL(Content content)
        {
            throw new NotImplementedException();
        }

        public Content GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Content> GetList()
        {
            throw new NotImplementedException();
        }

        //dısardan alacagımız baslık id başlığa gore ıcerık getırecek
        public List<Content> GetListByHeadingID(int id)
        {
            return _contentDal.List(x => x.HeadingId == id);
        }
    }
}
