using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            // 6 different implementations of Singleton design pattern
            // The best solution is Singleton Version 4


            Singleton_V1 singleton_V1 = Singleton_V1.Instance;
            Singleton_V2 singleton_V2 = Singleton_V2.Instance;
            Singleton_V3 singleton_V3 = Singleton_V3.Instance;
            Singleton_V4 singleton_V4 = Singleton_V4.Instance;
            Singleton_V5 singleton_V5 = Singleton_V5.Instance;
            Singleton_V6 singleton_V6 = Singleton_V6.Instance;



            // All examples were taken from book "C# In Depth" Jon Skeet
        }
    }
}
