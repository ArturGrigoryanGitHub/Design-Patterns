using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    //Singleton Version 6 - using .NET 4's Lazy<T> type
    public sealed class Singleton_V6
    {
        private static readonly Lazy<Singleton_V6> _lazy = new Lazy<Singleton_V6>(() => new Singleton_V6());
        private Singleton_V6()
        {
        }

        public static Singleton_V6 Instance
        {
            get
            {
                return _lazy.Value
            }
        }
    }
}
