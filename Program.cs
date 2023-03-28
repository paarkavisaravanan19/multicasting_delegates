namespace anononymous
{
    delegate void mathOperation(int a, int b);
    internal class Program
    {
        static void Main(string[] args)
        {
            //multicasting delegates ==> incase of void
            mathOperation d1 = add;
            mathOperation d2 = sub;
            mathOperation d3 = mult;
            mathOperation d5= d1+d2+d3;

            Delegate[] arr=d5.GetInvocationList();  
            d5.Invoke(2, 3);

        }

        public static void add(int a, int b)
        {
            Console.WriteLine(a + b);

        }
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