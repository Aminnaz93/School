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


    public static class MathHelper
    {

        public static int add(int a, int b)
        {
            return a + b;
        }

        public static int sub(int a, int b)
        {
            return a - b;
        }

        public static double mult(double a, double b)
        {
            return a * b;
        }

        public static double div(double a, double b)
        {
            return a / b;
        }



    }


} 