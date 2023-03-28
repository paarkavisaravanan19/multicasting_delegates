namespace anononymous
{
    delegate void mathOperation(int a, int b);
    internal class Program
    {
        static void Main(string[] args)
        {
            anononymous.LamdaEx ld = new anononymous.LamdaEx();
            ld.show();
            ld.Display();
            anononymous.user us = new anononymous.user();
            us.show1();

            //multicasting delegates ==> incase of void
            //mathOperation d1 = add;
            //mathOperation d2 = sub;
            //mathOperation d3 = mult;
            //mathOperation d5= d1+d2+d3;

            //Delegate[] arr=d5.GetInvocationList();  
            //d5.Invoke(2, 3);

            /*
            //anonymous or inline delegate invokation
            mathOperation del = delegate (int a, int b)
            {
                Console.WriteLine(a + b);
            };
            del.Invoke(10, 20);
            */
        }

        /*public static void  add(int a, int b)
        {
            Console.WriteLine(a + b);

        }*/
        public static void sub(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        public static void mult(int a, int b)
        {
            Console.WriteLine(a - b);
        }

    }
}