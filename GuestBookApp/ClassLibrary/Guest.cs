using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Guest
    {
        public string name { get; set; }
        public string message { get; set; }
        public DateTime messageTime { get; set; }

        public static Guest NewEntry()
        {
            Console.WriteLine("Enter your name: ");
            string newName = Console.ReadLine();
            Console.WriteLine("Enter your message: ");
            string newMessage = Console.ReadLine();
            Guest newGuest = new Guest()
            {
                name = newName,
                message = newMessage,
                messageTime = DateTime.Now
            };

            return newGuest;
        }

        public static List<Guest> AddToGuestList(List<Guest> GuestList, Guest newGuest)
        {
            GuestList.Add(newGuest);
            Console.WriteLine(GuestList.Count);
            return GuestList;
        }
    }
}
