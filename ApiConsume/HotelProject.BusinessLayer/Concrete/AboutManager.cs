using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        private readonly IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void TDelete(About t)
        {
            _aboutDal.TDelete(t);
        }

        public About TGetByID(int id)
        {
           return _aboutDal.GetByID(id);
        }

        public List<About> TGetList()
        {
           return _aboutDal.TGetList();
        }

        public void TInsert(About t)
        {
            _aboutDal.TInsert(t);
        }

        public void TUpdate(About t)
        {
            _aboutDal.TUpdate(t);
        }
    }
}
