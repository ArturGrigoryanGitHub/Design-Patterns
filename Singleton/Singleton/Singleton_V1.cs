using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    //Singletone Version 1 - not thread-safe
    //Bad Code!! Do not use!!
    public sealed class Singleton_V1
    {
        private static Singleton_V1 _instance = null;

        private Singleton_V1()
        {
        }

        public static Singleton_V1 Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Singleton_V1();
                }
                return _instance;
            }
        }
    }
}
