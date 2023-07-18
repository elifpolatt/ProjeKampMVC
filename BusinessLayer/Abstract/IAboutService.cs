using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IAboutService
    {
        List<About> Getlist();
        void AboutAdd(About about);
        About GetById(int id);
        void AboutRemove(About about);
        void AboutUpdate(About about);

    }
}
