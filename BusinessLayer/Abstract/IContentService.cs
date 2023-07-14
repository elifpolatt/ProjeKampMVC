using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IContentService
    {
        List<Content> GetList();
        //parametre listeleme
        List<Content> GetListByHeadingID(int id); //burada başlığa gore içerik getirmeyi hazırlamış olduk 
        void ContentAddBL(Content content);
        Content GetByID(int id); //Tek deger döndürür
        void ContentRemoveBL(Content content);
        void ContentUpdateBL(Content content);
    }
}
