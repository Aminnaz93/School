using System;


namespace Utils
{
    public static class Methods
    {
        public static void Greeting()
        {
            Console.WriteLine("Hello from Utils!");
        }


        public static int add(int a, int b)
        {
            return a + b;
        }


        public static void myLoop()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }



    }
} 