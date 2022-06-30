using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class ItemsList
    {
        public List<Item> items;

        public void AddItem(int serialNumber, DateTime duration, string title, string author, DateTime year, string genre, bool isAvailable, int inShelf)
        {
            Dvd newDvd = new Dvd(serialNumber, duration, title, author, year, genre, isAvailable, inShelf);
            items.Add(newDvd);
        }

        public void AddItem(string ISBN, int numberPages, string title, string author, DateTime year, string genre, bool isAvailable, int inShelf)
        {
            Boock newBoock = new Boock(ISBN, numberPages, title, author, year, genre, isAvailable, inShelf);
            items.Add(newBoock);
        }

        public Item FindItem(string identifier)
        {
            foreach (Boock boock in items) { 
                if(identifier == boock.title || identifier == boock.ISBN)
                {
                    return boock;
                }
            }
            foreach (Dvd dvd in items)
            {
                if (identifier == dvd.title)
                {
                    return dvd;
                }
            }
            return null;
        }

        public Item FindItem(int identifier)
        {
            foreach (Dvd dvd in items)
            {
                if (identifier == dvd.serialNumber)
                {
                    return dvd;
                }
            }
            return null;
        }
    }
}
