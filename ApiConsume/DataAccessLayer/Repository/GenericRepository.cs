using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        private readonly Context _context;

        public GenericRepository(Context context)
        {
            _context = context;
        }

        public void TDelete(T t)
        {
            _context.Remove(t);
            _context.SaveChanges();
        }

        public T GetByID(int id)
        {
           return _context.Set<T>().Find(id);
        }

        public List<T> TGetList()
        {
           return _context.Set<T>().ToList();
        }

        public void TInsert(T t)
        {
            _context.Add(t);
            _context.SaveChanges();
        }

        public void TUpdate(T t)
        {
            _context.Update(t);
            _context.SaveChanges();
        }
    }
}
