using System;
using System.Collections.Generic;

namespace AddressBookApp
{
    public class AddressBook
    {
        private List<Contact> contacts = new List<Contact>();
        //UC:1
        public void AddContact(Contact c)
        {
            contacts.Add(c);
            Console.WriteLine("Contact Added Successfully!");
        }
    }
}
