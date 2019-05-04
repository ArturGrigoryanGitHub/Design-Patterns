using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    //Singleton Version 3 - attempted thread-safety using double-check locking
    //Bad Code!! Do not use!!
    public sealed class Singleton_V3
    {
        private static Singleton_V3 _instance;
        private static readonly object _padlock = new object();

        private Singleton_V3()
        {
        }

        public static Singleton_V3 Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_padlock)
                    {
                        if (_instance == null)
                        {
                            _instance = new Singleton_V3();
                        }
                    }
                }

                return _instance;
            }
        }
    }
}
