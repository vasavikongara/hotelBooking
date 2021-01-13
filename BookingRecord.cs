using System;
using System.Collections.Generic;
using System.Text;

namespace HotelBooking
{
    public class BookingRecord
    {
        private string guest;
        private int room;
        private DateTime date;
        public BookingRecord(string guest, int room, DateTime date)
        {
            this.guest = guest;
            this.room = room;
            this.date = date;
        }

        public int getRoom()
        {
            return room;
        }

        public DateTime getDate()
        {
            return date;
        }

        public string getGuest()
        {
            return guest;
        }
    }
}
