using System;


    class Int
    {
        public static void divide(int a, int b)
        {
            int x = 0;
            try
            {
                x = a / b;
                //Console.WriteLine(x);
            }
            catch
            {
                Console.WriteLine("Cannot divide by zero");
            }
            finally
            {
                Console.WriteLine("{0} / {1} = {2}",a, b, x);
            }
        }
    }

