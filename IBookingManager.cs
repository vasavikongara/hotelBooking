using System;
using System.Collections.Generic;
using System.Text;

namespace HotelBooking
{
    interface IBookingManager
    {
        /**
           * Return true if there is no booking for the given room on the date, otherwise false.
           */
        bool isRoomAvailable(int room, DateTime date);

        /**
            * Add a booking for the given guest in the given room on the given date.  If the room is not available, throw a suitable exception.
            */
        void addBooking(String guest, int room, DateTime date);

        /**
            * Return a list of all the available room numbers for the given date.
            */
        List<int> getAvailableRooms(DateTime date);

    }
}
