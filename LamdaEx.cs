using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anononymous
{
    public delegate int add(int a, int b);
    public delegate void update(string msg);
    public class LamdaEx
    {




        public void Display()
        {
            List<user> student = new List<user>();
            student.Add(new user() { name = "paarkavi", rollno = 19, place = "apk", age = 20 });
            student.Add(new user() { name = "priya", rollno = 76, place = "mdu", age = 21 });
            student.Add(new user() { name = "dwarka", rollno = 81, place = "chn", age = 23 });
            student.Add(new user() { name = "vartha", rollno = 66, place = "cbe", age = 29 });
            student.Add(new user() { name = "madhura", rollno = 81, place = "pune", age = 28 });

            student.ForEach(student => student.rollno += 1);
            //sorting of age
            student.Sort((s1, s2) => s1.age - s2.age);

            // List<user> oldstudent = student.FindAll(stud => stud.age >20).ToList();
            foreach (var student1 in student)
            {
                //Console.WriteLine("student1");
                Console.WriteLine($"Name: {student1.name} Age : {student1.age}");
            }
            var result = (int x, int y) =>
            {
                int total = 0;
                total = x + y;
                return total;
            };
            Console.WriteLine("result: " + result(13, 89));










        }



        public void show()
        {
            /*
            //lambda expression
            add sum = (num1, num2) => num1 + num2;
            add sub = (num1,num2) => num1 - num2;
            add tot = sum + sub;
            
            Delegate[] arr = tot.GetInvocationList();
            Console.WriteLine( tot.Invoke(30, 20));

            //Console.WriteLine(sum.Invoke(10, 20));
            /*
            update up = (str) => Console.WriteLine(str);
            up.Invoke("paarkavi");
            */
            /*
            List<int> list = new List<int>() { 1,2,3,4,5,6,7,8};
            var square = (int n) => { return n * n; };
            foreach (int i in list)
            {
                Console.WriteLine(square(i));
            }
            */

            /*
            List<int> list1 = new List<int>() { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            List<int> Divisibleby5 =  list1.FindAll(x => x%5==0 );

            foreach(int i in Divisibleby5)
            {
                Console.WriteLine(i);

            }
            */
            //List<string> s1 = new List<string>() { "abc", "def", "ghi" };
            //List<string> contains = s1.OrderBy(s=> s ).ToList();
            //List<string> contains = s1.FindAll(x => x.Contains("a"));
            /*foreach(string s in contains)
            {
                Console.WriteLine(s);
            }
            */
            /*
            Dictionary<int, string> myDic= new Dictionary<int, string>();
            myDic.Add(1, "A");
            myDic.Add(5, "B");
            myDic.Add(3, "C");
            myDic.Add(6, "D");
            myDic.Add(8, "E");
            foreach(var keyValue in myDic.OrderByDescending(x => x.Value).ToList())
            {
                Console.WriteLine(keyValue);
            }
            */


        }



    }
    public class user
    {
        public string name { set; get; }
        public int rollno { set; get; }
        public int age { set; get; }
        public string place { set; get; }

        public void show1()
        {

            var result = (int x, int y) =>
            {
                int total = 0;
                total = x + y;
                return total;
            };
            Console.WriteLine("result: " + result(13, 89));



        }
    }
}
