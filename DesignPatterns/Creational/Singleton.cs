using System;
namespace DesignPatterns.Creational
{
    public class Singleton
    {
        private Singleton(){}

        private static Singleton _instance;
        public static Singleton Instance
        {
            get
            {
                if (_instance is null)
                    _instance = new Singleton();
                return _instance;
            }
        }

    }
}
