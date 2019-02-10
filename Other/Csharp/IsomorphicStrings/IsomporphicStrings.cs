﻿using System;
using System.Collections.Generic;

namespace MicrosoftTest
{
    public static class Program
    {
        static bool AreStringsIsomorphic(string a, string b)
        {
            Dictionary<char, char> map = new Dictionary<char, char>();
            bool indicator =true;
            for(int i=0; i<a.Length; i++)
            {
                for(int j=0; j< b.Length; j++)
                {
                    if (i<a.Length && !map.ContainsKey(a[i]) && !map.ContainsValue(b[j]))
                    { 
                        map[a[i++]]=b[j];
                        continue;
                    } 

                    if (i<a.Length && map.ContainsKey(a[i]) && map[a[i]]==b[j])
                    {
                        i++;
                        continue;
                    }
  
                    indicator = false;
                    break;
                }
            }
            return indicator;
        }               
        static void Main(string[] args)
        {
            string a = "brain";
            string b = "space";
            Console.WriteLine($"{a}, {b}, {AreStringsIsomorphic(a,b)}");
            a = "noon";
            b = "feet";
            Console.WriteLine($"{a}, {b}, {AreStringsIsomorphic(a,b)}");
            a = "aab";
            b = "ccd";
            Console.WriteLine($"{a}, {b}, {AreStringsIsomorphic(a,b)}");
            a = "ab";
            b = "cc";
            Console.WriteLine($"{a}, {b}, {AreStringsIsomorphic(a,b)}");
        }
    }
}