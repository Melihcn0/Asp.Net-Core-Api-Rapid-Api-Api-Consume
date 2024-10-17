using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repository;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.EntityFramework
{
    public class EfStaffDal : GenericRepository<Staff>, IStaffDal
    {
        public EfStaffDal(Context context) : base(context)
        {
        }
        public int GetStaffCount()
        {
            var context = new Context();
            return context.Staffs.Count();
        }

        public List<Staff> LastFourStaff()
        {
            var context = new Context();
            //return context.Staffs.OrderByDescending(x => x.StaffID).Take(4).ToList();
            return context.Staffs.OrderBy(x => Guid.NewGuid()).Take(4).ToList();
        }
    }
}
