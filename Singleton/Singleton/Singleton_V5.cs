namespace Singleton
{
    //Singleton Version 5 - fully lazy instantiation
    public sealed class Singleton_V5
    {
        private Singleton_V5()
        {
        }

        public static Singleton_V5 Instance
        {
            get
            {
                return Nested.instance;
            }
        }

        private class Nested
        {
            // Explicit static constructor to tell C# compiler
            // not to mark type as beforefieldinit
            static Nested()
            {
            }

            //Internal, for allowing Singleton_V5 to read it
            internal static readonly Singleton_V5 instance = new Singleton_V5();
        }
    }
}
