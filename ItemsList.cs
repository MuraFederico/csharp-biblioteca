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

        public ItemsList()
        {
            this.items = new List<Item>();
        }
        public void AddItem(int serialNumber, int duration, string title, string author, DateTime year, string genre, bool isAvailable, int inShelf)
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
            foreach (Item item in items)
            {
                if(item is Boock)
                {
                    Boock boock = (Boock)item;
                    if (identifier == boock.title || identifier == boock.ISBN)
                    {
                        return item;
                    }
                }else if(item is Dvd)
                {
                    if (identifier == item.title)
                    {
                        return item;
                    }
                }
            }
            return null;
        }

        public Item FindItem(int identifier)
        {
            foreach (Item item in items)
            {
                if(item is Dvd)
                {
                    Dvd dvd = (Dvd)item;
                    if (identifier == dvd.serialNumber)
                    {
                        return dvd;
                    }
                }
            }
            return null;
        }
    }
}
