using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IHeadingService
    {
        List<Heading> Getlist();
        void HeadingAddBL(Heading heading);

        Heading GetByID(int id);
        void HeadingRemoveBL(Heading heading);
        void HeadingUpdateBL(Heading heading);
    }
}
