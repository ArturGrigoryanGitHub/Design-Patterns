namespace Singleton
{
    // Singleton Version 2 - simple thread-safety
    public sealed class Singleton_V2
    {
        private static Singleton_V2 _instance = null;
        private static readonly object _padlock = new object();

        private Singleton_V2()
        {
        }

        public static Singleton_V2 Instance
        {
            get
            {
                lock (_padlock)
                {
                    if (_instance == null)
                    {
                        _instance = new Singleton_V2();
                    }
                    return _instance;
                }
            }
        }
    }
}
