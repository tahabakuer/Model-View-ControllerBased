using DataAccessLayerCRUD.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayerCRUD.Concrete.Repositories
{
    public class CategoryRepository : ICategoryDAL
    {
        Context c= new Context();
        DbSet<Category> _object;
        public void Delete(Category p)
        {
            _object.Remove(p);
            c.SaveChanges();
        }

        public void Insert(Category p)
        {
            _object.Add(p);
            c.SaveChanges();//this is a must for save
        }

        public List<Category> List()
        {
            return _object.ToList();
        }

        public void Update(Category p)
        {
            c.SaveChanges();// i will add updates before this func will work so its just need to save
        }
    }
}

/*
 * ToList
 * Add
 * Remove
 * Find
 * these are basic entity framework functions
 */
