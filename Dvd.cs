﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Dvd : Item
    {
        public int serialNumber;

        DateTime duration;
        public Dvd(int serialNumber, DateTime duration, string title, string author, DateTime year, string genre, bool isAvailable, int inShelf) : base(title, author, year, genre, isAvailable, inShelf)
        {
            this.duration = duration;
            this.serialNumber = serialNumber;
        }
    }
}
