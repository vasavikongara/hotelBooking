using System;
using System.Collections.Generic;

namespace HotelBooking
{
    public class ConsoleApplication
    {

        public ConsoleApplication()
        {

        }

        public void  Run(string[] args)
        {
            IBookingManager bookingManager = new HotelBookingManager(new List<int> { 101, 102, 201, 203 });

            DateTime today = DateTime.Today;

            Console.WriteLine(bookingManager.isRoomAvailable(101, today));
            bookingManager.addBooking("Smith", 101, today);

            Console.WriteLine("Available Rooms:");
            List<int> availabelList = bookingManager.getAvailableRooms(today);
            availabelList.ForEach(i => Console.WriteLine("{0}\t", i));

            Console.WriteLine(bookingManager.isRoomAvailable(101, today));

            bookingManager.addBooking("Jones", 102, today);
           
            bookingManager.addBooking("Li", 101, today);

        }
    }
}
