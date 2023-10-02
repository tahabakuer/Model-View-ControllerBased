using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayerCRUD.Concrete
{
    public class Context: DbContext
    {
        //Entity layer da bulunun sınıfları burada kullanabilmek için nce Entity framework'ü DAL'a ekledim
        //daha sonra kullanacağım sınıf üzerine DbContext'i kalıtım aldım
        //DAL'a referans olarak proje üserindeki katmanlardan EntityLayer'ı ekledim
        //DbSet değişkeni olarak kullancağım classları DAL altındaki scripte ekledim
        public DbSet<About>  Abouts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<Heading> Headings { get; set; }
        public DbSet<Writer> Writers { get; set; }
        //yukarıdaki tablolar SQL'e yansıyacak
    }
}
