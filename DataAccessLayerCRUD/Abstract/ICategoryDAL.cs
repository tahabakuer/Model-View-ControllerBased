using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayerCRUD.Abstract
{
    public interface ICategoryDAL
    {
        //CRUD Operation Handling
        List<Category> List();
        void Insert(Category p); //p Category param

        void Update(Category p);

        void Delete(Category p);
    }
}
