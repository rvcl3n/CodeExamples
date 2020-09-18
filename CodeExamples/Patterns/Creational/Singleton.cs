using System;
using System.Collections.Generic;
using System.Text;

namespace CodeExamples.Patterns.Creational
{
    public sealed class Singleton
    {
        private static volatile Singleton instance;
        private static object syncRoot = new object();

        private Singleton() { }

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new Singleton();
                    }
                }

                return instance;
            }
        }
    }
}
