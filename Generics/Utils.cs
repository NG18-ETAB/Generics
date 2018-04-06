﻿using System;

namespace Generics
{
    static class Utils
    {
        public static T Min<T>(T v1, T v2)
            where T:IComparable
        {
            if (v1.CompareTo(v2) > 0) return v2;
            return v1;
        }
    }
} 