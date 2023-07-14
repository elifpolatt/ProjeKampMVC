using EntityLayer.Concrete;  //bu içerikler entity katmanı içinde normalde ama data access katmanına gelip add dedik project solutiona tıkladık ve entity katmanını buraya dahil ettik. Aboutun veya digerlerinin üzerine gelerek bu kütüphaneyi ekledik.
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        public DbSet<About> Abouts{ get; set; }
        //about sınıf ismi abouts sqldeki tablonun ismi
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts  { get; set; }
        public DbSet<Content> Contents{ get; set; }
        public DbSet<Heading> Headings { get; set; }
        public DbSet<Writer> Writers { get; set; }

    }
}
