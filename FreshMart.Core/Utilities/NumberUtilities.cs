﻿using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace FreshMart.Core.Utilities
{
    public static class NumberUtilities
    {

        public static long GetUniqueNumber()
        {
            var length = 32;
            var bytes = new byte[length];
            var cryptoRandomDataGenerator = RandomNumberGenerator.Create();
            cryptoRandomDataGenerator.GetBytes(bytes);
            var random = BitConverter.ToUInt32(bytes, 0) % 100000000;
            return random;
        }

        public static IEnumerable<int> To(this int from, int to)
        {
            if (to >= from)
            {
                for (int i = from; i <= to; i++)
                {
                    yield return i;
                }
            }
            else
            {
                for (int i = from; i >= to; i--)
                {
                    yield return i;
                }
            }
        }

        public static IEnumerable<T> Times<T>(this int num, T toReturn)
        {
            for (int i = 0; i < num; i++)
            {
                yield return toReturn;
            }
        }

        public static IEnumerable<T> Times<T>(this int num, Func<int, T> block)
        {
            for (int i = 0; i < num; i++)
            {
                yield return block(i);
            }
        }

    }
}

