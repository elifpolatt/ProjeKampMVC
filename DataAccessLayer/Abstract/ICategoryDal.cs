using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    //IRepository^den gelen crud işlemleri icn degeleri al ve T degeri de = category olacaktır.
    //Bu generic yapı olarak gecmektedir. ama bunun cok daha kolay bır hali daha vardır o da generic repository olarak gecmektedir.

    public interface ICategoryDal : IRepository<Category>
    {

    }
}
