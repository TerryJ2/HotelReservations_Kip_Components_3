﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelsManagement
{
    public class Room
    {
        public enum BedType
        {
            KB,
            QB,
            DB,
            BS,
            NULL
        }

        public BedType BedSize { get; set; }
        public double DailyRate { get; set; }
        public int Capacity { get; set; }
        //public int Current { get; set; }
        //public String Name { get; set; }

        public Room() { }

        public Room(BedType bedSize, double DailyRate, int capacity)
        {
            this.BedSize = bedSize;
            this.Capacity = capacity;
            this.DailyRate = DailyRate;

            /*
            switch(this.BedSize)
            {
                default:  case BedType.KB: this.Name = "Single King Bed"; break;
                case BedType.QB: this.Name = "Single Queen Bed"; break;
                case BedType.DB: this.Name = "Two Double Beds"; break;
                case BedType.BS: this.Name = "One Bedroom Suite"; break;
            }
            */

        }
    }
}
