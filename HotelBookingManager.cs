using System;
using System.Collections.Generic;
using System.Linq;

namespace HotelBooking
{
        public class HotelBookingManager : IBookingManager
        {
            private readonly List<BookingRecord> bookings = new List<BookingRecord>();
            private readonly List<int> hotelRooms;

            public HotelBookingManager(List<int> hotelRooms)
            {
                this.hotelRooms = hotelRooms;
            }

            public bool isRoomAvailable(int room, DateTime date)
            {


                return bookings.Where(b => b.getDate() == date && b.getRoom() == room).ToList().Count == 0;


            }

            public void addBooking(String guest, int room, DateTime date)
            {

                if (!hotelRooms.Contains(room))
                {
                    throw new RoomNotFoundException(String.Format("Room {0} is not a valid room in the hotel", room));
                }
                if (!isRoomAvailable(room, date))
                {
                    throw new RoomNotFoundException(String.Format("Room {0} has already been booked for {1}", room, date));
                }
                BookingRecord bookingRecord = new BookingRecord(guest, room, date);
                bookings.Add(bookingRecord);
            }

            public List<int> getAvailableRooms(DateTime date)
            {
                return hotelRooms.Where(room => isRoomAvailable(room, date)).ToList();

            }

            public static HotelBookingManager create(List<int> hotelRooms)
            {
                return new HotelBookingManager(hotelRooms);
            }
        }
        public class RoomNotFoundException : Exception
        {
           public RoomNotFoundException(string message)
                : base(message)
            {
            }


        }
    
}
