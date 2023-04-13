
using System;

namespace degisken
{
    class Program
    {
        // See https://aka.ms/new-console-template for more information
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        
            byte b = 5;
            sbyte c = 5;
            short s = 5;
            ushort us = 5;
            Int16 i16 = 2;
            int i = 2;
            Int32 i32 = 2;
            Int64 i64 = 2;
        
            uint ui = 2;
            long l = 4;
            ulong ul = 4;
        
            //Reel sayilar
            float f = 5;
            double d = 5;
            decimal de = 5;
        
            char ch = '2';
        
            string str = "Akın"; //sinirsiz
            bool b1 = true;
            bool b2 = false;
        
            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);
        
            object o1 = "x";
            object o2 = 'y';
            object o3 = 4;
            object o4 = 4.3;
        
            // string ifadeler
            string str1 = string.Empty;
            str1 = "Akın Ayturan";
            string ad = "Akın";
            string soyad = "Ayturan";
            string tamIsim = ad + "" + soyad;
        
            //integer tanimlama sekilleri
            int integer1 = 5;
            int integer2 = 3;
            int integer3 = integer1 * integer2;
            
            // boolean
            bool bool1 = 10 > 2;
            
            // Degisken DÔnüsümleri
            string str20 = "20";
            int int20 = 20;
            string yeniDeger = str20 + int20.ToString();
            Console.WriteLine(yeniDeger);
        }
    }
};

