﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsiniBulOyunu
{
    public static class Islemler
    {
        static Random rnd = new Random();
        public static void Karistir<T>(IList<T> list)
        {
            T gecici;
            int talihliIndeks;

            for (int i = 0; i < list.Count; i++)
            {
                talihliIndeks = rnd.Next(i, list.Count);
                gecici = list[i];
                list[i] = list[talihliIndeks];
                list[talihliIndeks] = gecici; 
            }
        }
    }
}
