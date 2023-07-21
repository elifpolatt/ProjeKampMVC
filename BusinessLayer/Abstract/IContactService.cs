using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IContactService
    {
        List<Contact> GetList(int id);

        Contact GetByID(int id);
        void CategoryAdd(Contact contact);
        void CategoryRemove(Contact contact);
        void CategoryUpdate(Contact contact);
    }
}
