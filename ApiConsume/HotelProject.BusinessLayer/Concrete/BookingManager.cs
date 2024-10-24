﻿using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.EntityFramework;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
    public class BookingManager : IBookingService
    {
        private readonly IBookingDal _bookingDal;

        public BookingManager(IBookingDal bookingDal)
        {
            _bookingDal = bookingDal;
        }

        public void TBookingStatusChangeApproved(Booking booking)
        {
            throw new NotImplementedException();
        }

        public void TBookingStatusChangeApproved2(int id)//en son bunu yaptık
        {
            _bookingDal.BookingStatusChangeApproved2(id);
        }

        public void TBookingStatusChangeCancel(int id)
        {
            _bookingDal.BookingStatusChangeCancel(id);
        }

        public void TBookingStatusChangeWait(int id)
        {
            _bookingDal.BookingStatusChangeWait(id);
        }

        public void TBookingStatusDetails(int id)
        {
            _bookingDal.BookingStatusDetails(id);
        }

        public void TDelete(Booking t)
        {
            _bookingDal.TDelete(t);
        }

        public int TGetBookingCount()
        {
            return _bookingDal.GetBookingCount();
        }

        public Booking TGetByID(int id)
        {
           return _bookingDal.GetByID(id);
        }

        public List<Booking> TGetList()
        {
            return _bookingDal.TGetList();
        }

        public void TInsert(Booking t)
        {
            _bookingDal.TInsert(t);
        }

        public List<Booking> TLastSixBooking()
        {
            return _bookingDal.LastSixBookings();
        }

        public void TUpdate(Booking t)
        {
            _bookingDal.TUpdate(t);
        }
    }
}
