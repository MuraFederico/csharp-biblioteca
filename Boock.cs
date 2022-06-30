using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Boock : Item
    {

        public string ISBN;
        public int numberPages;

        public Boock(string ISBN, int numberPages, string title, string author, DateTime year, string genre, bool isAvailable, int inShelf) : base(title, author, year, genre, isAvailable, inShelf)
        {
            this.numberPages = numberPages;
            this.ISBN = ISBN;
        }
    }
}
