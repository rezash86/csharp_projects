using myfirstapp.domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myfirstapp
{
    class Program
    {
        static void Main(string[] args)
        {
            //domain.User c = new domain.User();
            //c.Id = 12;

            int val = 50;
            Console.WriteLine("value before the methods " + val);
            //show(val);
            //show2(val);
            Console.WriteLine("value after the methods " + val);


            int[] users = new int[10];

            domain.User[] usersArr = new domain.User[10];

            //for (int i = 0; i < usersarr.length; i++)
            //{
            //    usersarr[i].id = 12;
            //}

            String[] myArr = { "Sun", "Mon", "Tue", "Thu" };

            string res = Array.Find(myArr, element => element.Contains('S'));

            Console.WriteLine("{0}", res);

            ArrayList myList = new ArrayList();
            myList.Add(new domain.User(1, "reza"));


            Hashtable table = new Hashtable();

            string textFile = @"testFile.txt";
            string[] lines = File.ReadAllLines(textFile);

            Console.WriteLine(lines.Length);

            // Delegate instantiation  
            delOperation del = new delOperation(addddd);

            del(12, 12);

        }

        public static void show(ref int val)
        {
            val *= val;
            Console.WriteLine("value in the methods " + val);
        }

        public static void show2(int val)
        {
            val *= val;
            Console.WriteLine("value in the methods " + val);
        }


        public delegate void delOperation(int a, int b);

        public static void addddd(int a, int b)
        {
            Console.WriteLine(a + b);
        }
    }
}
