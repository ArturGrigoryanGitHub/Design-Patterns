using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    //Best way to use Singleton pattern
    //Singleton Version 4 - not quite as lazy, but thread-safe without using locks
    public sealed class Singleton_V4
    {
        private static readonly Singleton_V4 _instance = new Singleton_V4();

        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        static Singleton_V4()
        {
        }

        private Singleton_V4()
        {
        }

        public static Singleton_V4 Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}
