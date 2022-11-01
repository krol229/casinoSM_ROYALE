using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Microsoft.Win32;
using System.Runtime.InteropServices.ComTypes;

namespace casino
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //начало, которое 
            Console.WriteLine("Напиши свое имя");
                string name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Привет, {name}, это казич, а это значит если твое число совпадет с рандомом, то ты выйграл(а)");
            Thread.Sleep(3000);
            while (true)
           { 
            int x = 1;

            //тут считается все рандомы и запоминаются тоже здесь
            //2
                Random rndd = new Random();
                int rd = rndd.Next(1, 2);
            //3
                Random rnt = new Random();
                int rt = rnt.Next(1, 3);
            //4
            Random rnch = new Random();
            int rch = rnch.Next(1, 4);
            //5
            Random rnp = new Random();
            int rcp = rnp.Next(1, 5);
            //меню
            Console.WriteLine($"Привет, {name}, ты находишься в главном меню");   
                Console.WriteLine("                    ");
                Console.WriteLine("1. 1/2");
                Console.WriteLine("2. 1/3");
                Console.WriteLine("3. 1/4");
                Console.WriteLine("4. 1/5");
                Console.WriteLine("Напиши цифру режима, в который хочешь поиграть");
              int num =  Convert.ToInt32(Console.ReadLine());
            int numberMENU = (num + x);
            
            //менюшка сверху
            if(numberMENU == 2){
                Console.WriteLine("Ты выбрал(а) 1/2");
            }
            if (numberMENU == 3)
            {
                Console.WriteLine("Ты выбрал(а) 1/3");
            }
            if (numberMENU == 4)
            {
                Console.WriteLine("Ты выбрал(а) 1/4");
            }
            if (numberMENU == 5)
            {
                Console.WriteLine("Ты выбрал(а) 1/5");
            }
           //сам казич
            //1/2
            if (numberMENU == 2)
            {
                Console.WriteLine("Введите число число от 1 до 2: ");
                int dva = Convert.ToInt32(Console.ReadLine());
                if (dva == rd)
                {
                    Console.WriteLine("Ты выйграл(а)");
                }
                else 
                 {
                   Console.WriteLine($"Ты не выйграл(а), выпало число {rd}");
                 }


            }
            //1/3
            if (numberMENU == 3)
            {
                Console.WriteLine("Введите число число от 1 до 3: ");
                int tri = Convert.ToInt32(Console.ReadLine());
                if (tri == rt)
                {
                    Console.WriteLine("Ты выйграл(а)");
                }
                else
                {
                    Console.WriteLine($"Ты не выйграл(а), выпало число {rt}");
                }
            }
            //1/4
            if (numberMENU == 4)
            {
                Console.WriteLine("Введите число число от 1 до 4: ");
                int ch = Convert.ToInt32(Console.ReadLine());
                if (ch == rch)
                {
                    Console.WriteLine("Ты выйграл(а)");
                }
                else
                {
                    Console.WriteLine($"Ты не выйграл(а), выпало число {rch}");
                }
            }
            //1/5
            if (numberMENU == 5)
            {
                Console.WriteLine("Введите число число от 1 до 5: ");
                int p = Convert.ToInt32(Console.ReadLine());
                if (p == rcp)
                {
                    Console.WriteLine("Ты выйграл(а)");
                }
                else
                {
                    Console.WriteLine($"Ты не выйграл(а), выпало число {rcp}");
                }
            }

            //сам рандом
            //  Random rnd = new Random();
            // int r = rnd.Next(1, 2);
            Thread.Sleep(4000);
            Console.Clear();
            }
        }
    }
}