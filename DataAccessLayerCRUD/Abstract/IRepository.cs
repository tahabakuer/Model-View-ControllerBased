using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayerCRUD.Abstract
{
    public interface IRepository<T>// T is Table param
    {
        //CRUD
        List<T> List();
        void Insert(T p); //p Tables param

        void Update(T p);

        void Delete(T p);
    }
}
