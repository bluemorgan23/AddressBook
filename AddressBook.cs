using System;
using System.Collections.Generic;

namespace Address_Book
{
    public class AddressBook
    {
        public List<Contact> Contacts { get; set; } = new List<Contact>();
        public void AddContact(Contact contact)
        {
            this.Contacts.Add(contact);
        }

        public Contact GetByEmail(string email)
        {
            
               foreach(Contact contact in Contacts)
                {
                    
                        if(contact.Email == email)
                        {
                            return contact;
                        }
                   
                } 
            return null;
        }
    }
}