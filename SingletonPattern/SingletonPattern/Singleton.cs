using System;
namespace Singleton
{
    public class SingletonEagerInstantiation
    {
        private SingletonEagerInstantiation()
        {

        }

        private static readonly SingletonEagerInstantiation Instance = new SingletonEagerInstantiation();

        public static SingletonEagerInstantiation GetInstance()
        {
            return Instance;
        }
    }

    public class SingletonSync
    {
        private static SingletonSync instance = null;
        private static readonly object padlock = new object();

        private SingletonSync()
        {

        }

        public static SingletonSync GetInstance()
        {
            lock(padlock)
            {
                if(instance == null)
                {
                    instance = new SingletonSync();
                }
                return instance;
            }
        }
    }

    public class SingletonSyncDoubleLocking
    {
        private static SingletonSyncDoubleLocking instance = null;
        private static readonly object padlock = new object();

        private SingletonSyncDoubleLocking()
        {

        }

        public static SingletonSyncDoubleLocking GetInstance()
        {
            if(instance == null)
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new SingletonSyncDoubleLocking();
                    }
                }
            }
            return instance;
        }
    }
}